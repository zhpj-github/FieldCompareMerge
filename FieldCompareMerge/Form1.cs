using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FieldCompareMerge
{
    public partial class MainForm : Form
    {
        DbHelper helper = new DbHelper();
        public MainForm() {
            InitializeComponent();
        }

        private void btnSelectTable_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtDataBaseAddress.Text)
                || string.IsNullOrWhiteSpace(txtDatabase.Text)
                || string.IsNullOrWhiteSpace(txtUser.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text)) {
                MessageBox.Show("数据库连接信息不完整");
                return;
            }

            helper.DbAddress = txtDataBaseAddress.Text.Trim();
            helper.Database = txtDatabase.Text.Trim();
            helper.User = txtUser.Text.Trim();
            helper.Password = txtPassword.Text.Trim();
            SelectTable dlg = new SelectTable(helper);
            if (dlg.ShowDialog() == DialogResult.OK) {
                string tableName = dlg.TableName;
                lblTargetTableName.Text = tableName;
                dataGridViewTarget.DataSource = helper.LoadTableData(tableName);
                DataTable colTable= helper.LoadColumns(tableName);
                DataTable tempCol = colTable.DefaultView.ToTable(true, "COLUMN_NAME");
                combSelectedField.DataSource = tempCol;
                combSelectedField.DisplayMember = "COLUMN_NAME";

                combKeyField.DataSource = tempCol.Copy();
                combKeyField.DisplayMember = "COLUMN_NAME";
            }
        }

        private void btnGuid_Click(object sender, EventArgs e) {
            this.txtGuid.Text = Guid.NewGuid().ToString();
        }

        private void btnInputTable_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtXmlPath.Text)) {
                MessageBox.Show("先选择xml文件路径");
                return;
            }
            string xml = File.ReadAllText(txtXmlPath.Text);
            DataSet ds = ConvertXMLToDataSet(xml);
            if(ds==null || ds.Tables.Count<=0) {
                MessageBox.Show("xml文件中无数据或数据不合法");
                return;
            }
            dataGridViewSource.DataSource = ds.Tables[0];
            lblSourceTableName.Text = ds.Tables[0].TableName;
        }

        private void btnSelectFile_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "xml|*.xml";
            if(dlg.ShowDialog()== DialogResult.OK) {
                this.txtXmlPath.Text = dlg.FileName;
            }
        }

        private void btnOutputTarget_Click(object sender, EventArgs e) {
            DataTable dt = this.dataGridViewTarget.DataSource as DataTable;
            if (dt == null) {
                return;
            }
            OutputToXml(dt);
        }

        private void btnOutputSource_Click(object sender, EventArgs e) {
            DataTable dt = this.dataGridViewSource.DataSource as DataTable;
            if (dt == null) {
                return;
            }
            OutputToXml(dt);
        }

        private void btnAutoCopy_Click(object sender, EventArgs e) {
            MergeFieldValue();
        }
        private void btnSelectCopy_Click(object sender, EventArgs e) {
            MergeFieldSelected();
        }

        private void btnCopyToSource_Click(object sender, EventArgs e) {
            CopySelectDataToSource();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (SaveChangedTableToDB()) {
                MessageBox.Show("保存成功");
            }
        }

        /// <summary>
        /// datatable导出xml文件
        /// </summary>
        /// <param name="dt"></param>
        private void OutputToXml(DataTable dt) {
            string xml = ConvertDataTableToXML(dt);
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "xml|*.xml";
            dlg.DefaultExt = "xml";
            dlg.AddExtension = true;
            dlg.FileName = "DataTableXml";
            if (dlg.ShowDialog() == DialogResult.OK) {
                string path = dlg.FileName;
                File.WriteAllText(path, xml);
            }
        }
        /// <summary>
        /// datatable转换为xml格式字符串
        /// </summary>
        /// <param name="xmlDS"></param>
        /// <returns></returns>
        private string ConvertDataTableToXML(DataTable xmlDS) {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            try {
                stream = new MemoryStream();
                writer = new XmlTextWriter(stream, Encoding.UTF8);
                xmlDS.WriteXml(writer,XmlWriteMode.WriteSchema);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);
                UTF8Encoding utf = new UTF8Encoding();
                return utf.GetString(arr).Trim();
            } catch(Exception ex) {
                return ex.Message;
            } finally {
                if (writer != null) writer.Close();
            }
        }
        /// <summary>
        /// xml格式字符串转换dataset
        /// </summary>
        /// <param name="xmlData"></param>
        /// <returns></returns>
        private DataSet ConvertXMLToDataSet(string xmlData) {
            StringReader stream = null;
            XmlTextReader reader = null;
            try {
                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmlData);
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                return xmlDS;
            } catch (Exception ex) {
                string strTest = ex.Message;
                return null;
            } finally {
                if (reader != null)
                    reader.Close();
            }
        }
        /// <summary>
        /// 自动合并目标字段
        /// </summary>
        private void MergeFieldValue() {
            if (string.IsNullOrWhiteSpace(combSelectedField.Text)
                ||string.IsNullOrWhiteSpace(combKeyField.Text)) {
                return;
            }
            if (string.Equals(combKeyField.Text, combSelectedField.Text)) {
                MessageBox.Show("关键字字段与更新字段不能相同");
                return;
            }
            string keyName = combKeyField.Text;
            string filedName = combSelectedField.Text;

            DataTable sourceDT = this.dataGridViewSource.DataSource as DataTable;
            DataTable targetDT = this.dataGridViewTarget.DataSource as DataTable;
            foreach (DataRow row in targetDT.Rows) {
                if (row[keyName] == DBNull.Value) {
                    continue;
                }
                DataRow tempRow= sourceDT.AsEnumerable().FirstOrDefault(p => p.Field<string>(keyName) == row[keyName].ToString());
                if (tempRow == null) {
                    continue;
                }
                row[filedName] = tempRow[filedName];
            }
            this.dataGridViewTarget.Refresh();
        }
        /// <summary>
        /// 合并选择字段
        /// </summary>
        private void MergeFieldSelected() {
            if (string.IsNullOrWhiteSpace(combSelectedField.Text)) {
                return;
            }
            string filedName = combSelectedField.Text;
            DataTable targetDT = this.dataGridViewTarget.DataSource as DataTable;

            if (dataGridViewSource.SelectedRows.Count > 0 && dataGridViewTarget.SelectedRows.Count > 0) {
                object sourceValue = dataGridViewSource.SelectedRows[0].Cells[filedName].Value;
                if (!chkUnique.Checked) {
                    DataRow tempRow = targetDT.AsEnumerable().FirstOrDefault(p => p.Field<object>(filedName).ToString() == sourceValue.ToString());
                    if (tempRow != null) {
                        MessageBox.Show("选择重复，不允许操作");
                        return;
                    }
                }
                dataGridViewTarget.SelectedRows[0].Cells[filedName].Value = sourceValue;
            }
        }
        /// <summary>
        /// 赋值目标表中选择项到源表
        /// </summary>
        private void CopySelectDataToSource() {
            if (string.IsNullOrWhiteSpace(combSelectedField.Text)) {
                return;
            }
            string filedName = combSelectedField.Text;
            DataTable sourceDT = this.dataGridViewSource.DataSource as DataTable;
            DataTable targetDT = this.dataGridViewTarget.DataSource as DataTable;

            if (dataGridViewTarget.SelectedRows.Count > 0) {
                object sourceValue = dataGridViewTarget.SelectedRows[0].Cells[filedName].Value;
                if (!chkUnique.Checked) {
                    DataRow tempRow = sourceDT.AsEnumerable().FirstOrDefault(p => p.Field<string>(filedName) == sourceValue.ToString());
                    if (tempRow != null) {
                        MessageBox.Show("选择重复，不允许操作");
                        return;
                    }
                }

                DataRow row = (dataGridViewTarget.SelectedRows[0].DataBoundItem as DataRowView).Row;
                sourceDT.Rows.Add(row.ItemArray);
            }
        }
        /// <summary>
        /// 保存目标表到数据库
        /// </summary>
        /// <returns></returns>
        private bool SaveChangedTableToDB() {
            if (string.IsNullOrWhiteSpace(combSelectedField.Text)
                || string.IsNullOrWhiteSpace(combKeyField.Text)) {
                return false;
            }
            if (string.Equals(combKeyField.Text, combSelectedField.Text)) {
                MessageBox.Show("关键字字段与更新字段不能相同");
                return false;
            }
            string keyName = combKeyField.Text;
            string filedName = combSelectedField.Text;
            string tableName = lblTargetTableName.Text;
            DataTable targetDT = this.dataGridViewTarget.DataSource as DataTable;
            return helper.SaveTableToDB(targetDT, tableName, keyName, filedName);
        }
    }
}
