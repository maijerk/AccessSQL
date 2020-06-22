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
    public partial class DBForm : Form
    {
        private OleDbConnection connection;

        private DBForm()
        {
            InitializeComponent();
        }

        public DBForm(OleDbConnection conn) : this()
        {
            connection = conn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openDatabase();
        }
 
        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTables.SelectedItems.Count > 0)
            {
                String selectedTable = lstTables.SelectedItems[0].Text;
                
                tableDataGrid.DataSource = GetData(connection, selectedTable);
                tableDataGrid.DataMember = selectedTable;

            }
        }

        public static DataSet GetData(OleDbConnection conn, String table)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("bank");
            String query = "Select * from " + table + " order by 1";
            
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(ds, table);
            return ds;
        }

        private void openDatabase()
        {
            DataTable dt = connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });

            foreach (DataRow row in dt.Rows)
            {
                lstTables.Items.Add(row[2].ToString(), 0);
            }
            
        }


    }
}
