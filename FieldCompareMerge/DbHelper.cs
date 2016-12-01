using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldCompareMerge
{
    public class DbHelper
    {
        private string m_address;
        private string m_database;
        private string m_user;
        private string m_password;

        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }
        public string User
        {
            get { return m_user; }
            set { m_user = value; }
        }
        public string Database
        {
            get { return m_database; }
            set { m_database = value; }
        }
        public string DbAddress
        {
            get { return m_address; }
            set { m_address = value; }
        }

        public string ConnectionString
        {
            get
            {                
                return string.Format("Provider=SQLOLEDB.1;Password={3};Persist Security Info=True;User ID={2};Initial Catalog={1};Data Source={0}", DbAddress, Database, User, Password);
            }
        }
        public OleDbConnection Conn {
            get {
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                conn.Open();
                return conn;
            }
        }

        public DbHelper() { }

        public DataTable LoadTables() {
            using (Conn) {
                string[] restrictionValues = { null, null, null, "Table" };
                DataTable schTable = Conn.GetSchema("Tables", restrictionValues);
                return schTable;
            }
        }
        public DataTable LoadColumns(string tableName) {
            using (Conn) {
                string[] restrictionValues = { null, null, tableName, null };
                DataTable schTable = Conn.GetSchema("Columns", restrictionValues);
                return schTable;
            }
        }

        public DataTable LoadTableData(string tableName) {
            using (Conn) {
                OleDbCommand commd = new OleDbCommand();
                commd.Connection = Conn;
                commd.CommandText = string.Format("select * from {0}", tableName);
                OleDbDataAdapter adap = new OleDbDataAdapter(commd);
                DataTable dt = new DataTable(tableName);
                adap.Fill(dt);
                return dt;
            }
        }
    }
}
