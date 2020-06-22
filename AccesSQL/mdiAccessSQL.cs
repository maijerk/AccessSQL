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
    public partial class MDIParent : Form
    {
        private OleDbConnection connection;
        private string databasename;
        private string strokendiagramFileName;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            openDBFileDialog.InitialDirectory = Application.StartupPath;
            openDBFileDialog.Filter = "MS Access files (*.mdb)|*.mdb";
            if (openDBFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                String fileName = openDBFileDialog.FileName;
                databasename = System.IO.Path.GetFileNameWithoutExtension(fileName);
                strokendiagramFileName = System.IO.Path.GetDirectoryName(fileName) + "\\" + databasename + ".png";
                if (System.IO.File.Exists(strokendiagramFileName))
                {
                    strokendiagramToolStripMenuItem.Enabled = true;
                }

                CloseDatabase();
                if (OpenDatabase(fileName))
                {
                    DBForm childForm = new DBForm(connection);
                    childForm.MdiParent = this;
                    childForm.Text = databasename;
                    childForm.Show();

                    sqlMenuItem.Enabled = true;
                    databaseMenuItem.Enabled = true;
                    closeToolStripMenuItem.Enabled = true;
                    toolStripStatusLabel.Text = "Actieve database: " + fileName;
                }
            }

        }

        private bool OpenDatabase(string fileName)
        {
            connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + fileName + "; Persist Security Info = False");
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout bij openen database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void CloseDatabase()
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            if (connection?.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseDatabase();

            sqlMenuItem.Enabled = false;
            databaseMenuItem.Enabled = false;
            closeToolStripMenuItem.Enabled = false;

            toolStripStatusLabel.Text = "Status";

        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLForm childForm = new SQLForm(connection);
            childForm.MdiParent = this;
            childForm.Text = databasename;
            childForm.Show();

        }

        private void databaseMenuItem_Click(object sender, EventArgs e)
        {
            DBForm childForm = new DBForm(connection);
            childForm.MdiParent = this;
            childForm.Text = databasename;
            childForm.Show();

        }

        private void strokendiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrokendiagramForm childForm = new StrokendiagramForm();
            childForm.MdiParent = this;
            childForm.Text = databasename;

            if (System.IO.File.Exists(strokendiagramFileName))
            {
                childForm.BackgroundImage = Image.FromFile(strokendiagramFileName);
            }

            childForm.Show();

        }
    }
}
