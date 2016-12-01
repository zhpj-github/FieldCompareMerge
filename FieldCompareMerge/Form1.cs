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
            if (string.IsNullOrWhiteSpace(txtDataBaseAddress.Text)) {
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDatabase.Text)) {
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUser.Text)) {
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) {
                return;
            }
            helper.DbAddress = txtDataBaseAddress.Text.Trim();
            helper.Database = txtDatabase.Text.Trim();
            helper.User = txtUser.Text.Trim();
            helper.Password = txtPassword.Text.Trim();
            SelectTable dlg = new SelectTable(helper);
            if (dlg.ShowDialog() == DialogResult.OK) {
                string tableName = dlg.TableName;
                dataGridView1.DataSource = helper.LoadTableData(tableName);
                DataTable colTable= helper.LoadColumns(tableName);
                DataTable tempCol = colTable.DefaultView.ToTable(true, "COLUMN_NAME");
                combSelectedField.DataSource = tempCol;
                combSelectedField.DisplayMember = "COLUMN_NAME";
            }
        }

        private void btnGuid_Click(object sender, EventArgs e) {
            this.txtGuid.Text = Guid.NewGuid().ToString();
        }

        private void btnInputTable_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtXmlPath.Text)) {
                return;
            }
            string xml = File.ReadAllText(txtXmlPath.Text);
            DataSet ds = ConvertXMLToDataSet(xml);
            if(ds==null || ds.Tables.Count <= 0) {
                return;
            }
            dataGridView2.DataSource = ds.Tables[0];
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
            DataTable dt = this.dataGridView1.DataSource as DataTable;
            if (dt == null) {
                return;
            }
            OutputToXml(dt);
        }

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

        private string ConvertDataTableToXML(DataTable xmlDS) {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            try {
                stream = new MemoryStream();
                writer = new XmlTextWriter(stream, Encoding.UTF8);
                xmlDS.WriteXml(writer);
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

        private void btnOutputSource_Click(object sender, EventArgs e) {
            DataTable dt = this.dataGridView2.DataSource as DataTable;
            if (dt == null) {
                return;
            }
            OutputToXml(dt);
        }
    }
}
