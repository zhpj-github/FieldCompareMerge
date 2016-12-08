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
        private DataTable sourceData = null;//原始源表数据
        private DataTable targetData = null;//原始目标表数据

        DbHelper helper = new DbHelper();
        public MainForm() {
            InitializeComponent();
        }

        private void btnSelectTable_Click(object sender, EventArgs e) {
            SelectTable dlg = new SelectTable(helper);
            if (dlg.ShowDialog() == DialogResult.OK) {
                string tableName = dlg.TableName;
                lblTargetTableName.Text = tableName;
                DataTable dataDT= helper.LoadTableData(tableName);
                targetData = dataDT.Copy();
                dataGridViewTarget.DataSource = dataDT;
                DataTable colTable= helper.LoadColumns(tableName);                
                DataTable tempCol = colTable.DefaultView.ToTable(true, "COLUMN_NAME");
                combKeyField.DataSource = tempCol;
                combKeyField.DisplayMember = "COLUMN_NAME";
            }
        }

        private void btnInputTable_Click(object sender, EventArgs e) {
            SelectXMLFileInput();
        }

        private void SelectXMLFileInput() {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "xml|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK) {
                this.txtXmlPath.Text = dlg.FileName;

                string xml = File.ReadAllText(txtXmlPath.Text);
                DataSet ds = ConvertXMLToDataSet(xml);
                if (ds == null || ds.Tables.Count <= 0) {
                    MessageBox.Show("xml文件中无数据或数据不合法");
                    return;
                }
                sourceData = ds.Tables[0].Copy();
                dataGridViewSource.DataSource = ds.Tables[0];
                lblSourceTableName.Text = ds.Tables[0].TableName;
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
                MessageBox.Show("关键字字段或更新字段必须选择");
                return;
            }
            if (string.Equals(combKeyField.Text, combSelectedField.Text)) {
                MessageBox.Show("关键字字段与更新字段不能相同");
                return;
            }
            string keyName = combKeyField.Text;
            string filedName = combSelectedField.Text;
            string msg = string.Format("确定使用关键字段【{0}】进行合并吗?", keyName);
            if (MessageBox.Show(msg, "请确认", MessageBoxButtons.OKCancel) != DialogResult.OK) {
                return;
            }
            DataTable source = this.dataGridViewSource.DataSource as DataTable;
            DataTable target = this.dataGridViewTarget.DataSource as DataTable;
            if (source == null || target == null) {
                return;
            }
            DataTable sourceDT = source.Copy();
            DataTable targetDT = target.Copy();
            DataGridViewColumn col = new DataGridViewColumn();
            col.Name = "";
            DataTable combineDT = new DataTable("combine");
            string tKeyName = string.Format("T_{0}", keyName);//目标
            string sKeyName = string.Format("S_{0}", keyName);//源
            combineDT.Columns.Add(tKeyName);
            combineDT.Columns.Add(sKeyName);
            combineDT.Columns.Add(filedName);
            combineDT.Columns.Add("EQUAL", typeof(bool));
            dataGridViewTemp.DataSource = combineDT;
            foreach (DataRow row in targetDT.Rows) {
                if (row[keyName] == DBNull.Value) {
                    continue;
                }
                DataRow tempRow= sourceDT.AsEnumerable().FirstOrDefault(p => p.Field<object>(keyName).ToString() == row[keyName].ToString());
                if (tempRow == null) {
                    continue;
                }
                bool isEqual = false;
                if (row[filedName] != DBNull.Value && tempRow[filedName] != DBNull.Value) {
                    if (string.Equals(row[filedName].ToString(), tempRow[filedName].ToString(),StringComparison.OrdinalIgnoreCase)) {
                        isEqual=true;
                    }
                }

                DataRow combineRow = combineDT.NewRow();
                combineRow[tKeyName] = row[keyName];
                combineRow[sKeyName] = tempRow[keyName];
                combineRow[filedName] = tempRow[filedName];
                combineRow["EQUAL"] = isEqual;
                combineDT.Rows.Add(combineRow);

                DataGridViewRow dgvTRow= dataGridViewTarget.Rows.Cast<DataGridViewRow>().FirstOrDefault(p => Equals(p.Cells[keyName].Value, row[keyName]));
                (dgvTRow.DataBoundItem as DataRowView).Row.Delete();
                DataGridViewRow dgvSRow = dataGridViewSource.Rows.Cast<DataGridViewRow>().FirstOrDefault(p => Equals(p.Cells[keyName].Value, tempRow[keyName]));
                (dgvSRow.DataBoundItem as DataRowView).Row.Delete();
            }
            foreach (DataGridViewRow dgvRow in dataGridViewTemp.Rows) {
                object objEqual = dgvRow.Cells["EQUAL"].Value;
                if (objEqual is bool) {
                    if ((bool)objEqual) {
                        dgvRow.DefaultCellStyle.BackColor = Color.Gray;
                    } else {
                        dgvRow.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            source.AcceptChanges();
            target.AcceptChanges();
            this.dataGridViewTemp.Refresh();
        }
        /// <summary>
        /// 合并选择字段
        /// </summary>
        private void MergeFieldSelected() {
            if (string.IsNullOrWhiteSpace(combSelectedField.Text)) {
                MessageBox.Show("更新字段必须选择");
                return;
            }
            string filedName = combSelectedField.Text;
            DataTable targetDT = this.dataGridViewTarget.DataSource as DataTable;

            if (dataGridViewSource.SelectedRows.Count > 0 && dataGridViewTarget.SelectedRows.Count > 0) {
                object sourceValue = dataGridViewSource.SelectedRows[0].Cells[filedName].Value;
                DataRow tempRow = targetDT.AsEnumerable().FirstOrDefault(p => p.Field<object>(filedName).ToString() == sourceValue.ToString());
                if (tempRow != null) {
                    MessageBox.Show("选择重复，不允许操作");
                    return;
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
                DataRow tempRow = sourceDT.AsEnumerable().FirstOrDefault(p => p.Field<string>(filedName) == sourceValue.ToString());
                if (tempRow != null) {
                    MessageBox.Show("选择重复，不允许操作");
                    return;
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
                MessageBox.Show("关键字字段或更新字段必须选择");
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

        private void btnOpenDB_Click(object sender, EventArgs e) {
            if (OpenDatabase()) {
                btnCloseDB.Enabled = true;
                btnOpenDB.Enabled = false;
                panelDB.Enabled = false;

                btnSelectTable.Enabled = true;
                this.combSelectedField.SelectedIndex = 0;
            } else {
                btnOpenDB.Enabled = true;
                panelDB.Enabled = true;

                btnSelectTable.Enabled = false;
            }
        }

        private bool OpenDatabase() {
            if (string.IsNullOrWhiteSpace(txtDataBaseAddress.Text)
                || string.IsNullOrWhiteSpace(txtDatabase.Text)
                || string.IsNullOrWhiteSpace(txtUser.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text)) {
                MessageBox.Show("数据库连接信息不完整");
                return false;
            }

            helper.DbAddress = txtDataBaseAddress.Text.Trim();
            helper.Database = txtDatabase.Text.Trim();
            helper.User = txtUser.Text.Trim();
            helper.Password = txtPassword.Text.Trim();
            if (!helper.OpenConn()) {
                MessageBox.Show("打开数据库失败，请检查连接信息");
                return false;
            }
            return true;
        }

        private void btnCloseDB_Click(object sender, EventArgs e) {
            panelDB.Enabled = true;
            btnOpenDB.Enabled = true;
            btnCloseDB.Enabled = false;

            btnSelectTable.Enabled = false;
        }

        private void subMenuItemDel_Click(object sender, EventArgs e) {
            if (dataGridViewTemp.SelectedRows.Count <= 0) {
                return;
            }
            RemoveCombinedItems();
        }
        /// <summary>
        /// 移除已合并的项
        /// </summary>
        private void RemoveCombinedItems() {
            string keyName = this.combKeyField.Text;
            string tKeyName = string.Format("T_{0}", keyName);//目标
            string sKeyName = string.Format("S_{0}", keyName);//源

            DataTable temp = dataGridViewTemp.DataSource as DataTable;
            DataTable targetDt = dataGridViewTarget.DataSource as DataTable;
            DataTable sourceDt = dataGridViewSource.DataSource as DataTable;
            bool isShow = false;
            foreach (DataGridViewRow row in dataGridViewTemp.SelectedRows) {
                bool isCan = true;
                if (row.Cells["EQUAL"].Value is bool) {
                    if ((bool)row.Cells["EQUAL"].Value) {
                        isCan = false;
                    }
                } else {
                    continue;
                }
                if (!isCan) {
                    isShow = true;
                    continue;
                }
                DataRow tempRow = (row.DataBoundItem as DataRowView).Row;
                DataRow tRow = targetData.AsEnumerable().FirstOrDefault(p => p[keyName].ToString() == tempRow[tKeyName].ToString());
                if (tRow != null) {
                    targetDt.Rows.Add(tRow.ItemArray);
                }
                DataRow sRow = sourceData.AsEnumerable().FirstOrDefault(p => p[keyName].ToString() == tempRow[sKeyName].ToString());
                if (tRow != null) {
                    sourceDt.Rows.Add(sRow.ItemArray);
                }
                temp.Rows.Remove(tempRow);
            }
            if (isShow) {
                MessageBox.Show("待合并字段相同的项合并后不允许删除");
            }
            this.dataGridViewTemp.Refresh();
            this.dataGridViewSource.Refresh();
            this.dataGridViewTarget.Refresh();
        }
    }
}
