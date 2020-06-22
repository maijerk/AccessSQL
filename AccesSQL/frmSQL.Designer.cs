namespace AccesSQL
{
    partial class SQLForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLForm));
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.sqlDataGrid = new System.Windows.Forms.DataGridView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.checkBoxSQLTemplate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSQL
            // 
            this.txtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQL.Location = new System.Drawing.Point(-1, -1);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(679, 138);
            this.txtSQL.TabIndex = 0;
            this.txtSQL.Text = "SELECT \r\nFROM \r\n";
            // 
            // sqlDataGrid
            // 
            this.sqlDataGrid.AllowUserToAddRows = false;
            this.sqlDataGrid.AllowUserToDeleteRows = false;
            this.sqlDataGrid.AllowUserToOrderColumns = true;
            this.sqlDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlDataGrid.Location = new System.Drawing.Point(-1, 187);
            this.sqlDataGrid.Name = "sqlDataGrid";
            this.sqlDataGrid.ReadOnly = true;
            this.sqlDataGrid.Size = new System.Drawing.Size(679, 262);
            this.sqlDataGrid.TabIndex = 6;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 142);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "&Uitvoeren";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // checkBoxSQLTemplate
            // 
            this.checkBoxSQLTemplate.AutoSize = true;
            this.checkBoxSQLTemplate.Location = new System.Drawing.Point(105, 148);
            this.checkBoxSQLTemplate.Name = "checkBoxSQLTemplate";
            this.checkBoxSQLTemplate.Size = new System.Drawing.Size(134, 17);
            this.checkBoxSQLTemplate.TabIndex = 9;
            this.checkBoxSQLTemplate.Text = "Gebruik query &sjabloon";
            this.checkBoxSQLTemplate.UseVisualStyleBackColor = true;
            this.checkBoxSQLTemplate.CheckedChanged += new System.EventHandler(this.checkBoxSQLTemplate_CheckedChanged);
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.checkBoxSQLTemplate);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.sqlDataGrid);
            this.Controls.Add(this.txtSQL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SQLForm";
            this.Text = "SQL";
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.DataGridView sqlDataGrid;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.CheckBox checkBoxSQLTemplate;
    }
}