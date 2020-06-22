using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesSQL
{
    public partial class SQLForm : Form
    {

        private OleDbConnection connection;
        private string saveSQL;

        private SQLForm()
        {
            InitializeComponent();
        }

        public SQLForm(OleDbConnection conn) : this()
        {
            connection = conn;
        }

        public DataSet GetData()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("sql");
            String query = txtSQL.Text;

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            try
            {
                if (!query.Trim().EndsWith(";"))
                {
                    throw new ArgumentException("Query niet correct afgesloten");
                }
                adapter.Fill(ds, "sql");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            sqlDataGrid.DataSource = GetData();
            sqlDataGrid.DataMember = "sql";            
        }

        private void checkBoxSQLTemplate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSQLTemplate.Checked)
            {
                saveSQL = txtSQL.Text;
                txtSQL.Text = "SELECT \r\nFROM \r\nWHERE \r\nGROUP BY \r\nHAVING \r\nORDER BY ";
            }
            else
            {
                txtSQL.Text = saveSQL;
            }
        }
    }
}
