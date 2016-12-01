using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldCompareMerge
{
    public partial class SelectTable : Form
    {
        private DbHelper helper = null;
        private string m_tableName;

        public string TableName
        {
            get { return m_tableName; }
            set { m_tableName = value; }
        }

        public SelectTable() {
            InitializeComponent();
        }
        public SelectTable(DbHelper helper):this() {
            this.helper = helper;
        }

        private void SelectTable_Load(object sender, EventArgs e) {
            DataTable dt = helper.LoadTables();
            DataColumn col = new DataColumn("SELECTED", typeof(bool));
            col.DefaultValue = false;
            dt.Columns.Add(col);
            DataTable tempTable = dt.DefaultView.ToTable(true, "TABLE_CATALOG", "TABLE_NAME", "DATE_CREATED");
            //tempTable.DefaultView.Sort = "TABLE_NAME ASC";
            dataGridView1.DataSource = tempTable;
        }

        private void btnSelected_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.TableName = dr.Cells["TABLE_NAME"].Value.ToString();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
