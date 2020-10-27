namespace WindowsFormsApp1
{
    partial class Library_Admin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bookadministration_lll = new System.Windows.Forms.LinkLabel();
            this.Useradministration_lll = new System.Windows.Forms.LinkLabel();
            this.InvNo_lbl = new System.Windows.Forms.Label();
            this.Titel_lbl = new System.Windows.Forms.Label();
            this.Author_lbl = new System.Windows.Forms.Label();
            this.Publisher_lbl = new System.Windows.Forms.Label();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.Condition_lbl = new System.Windows.Forms.Label();
            this.Search_txb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bookadministration_lll
            // 
            this.Bookadministration_lll.AutoSize = true;
            this.Bookadministration_lll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookadministration_lll.Location = new System.Drawing.Point(12, 50);
            this.Bookadministration_lll.Name = "Bookadministration_lll";
            this.Bookadministration_lll.Size = new System.Drawing.Size(114, 16);
            this.Bookadministration_lll.TabIndex = 0;
            this.Bookadministration_lll.TabStop = true;
            this.Bookadministration_lll.Text = "Bücherverwaltung";
            // 
            // Useradministration_lll
            // 
            this.Useradministration_lll.AutoSize = true;
            this.Useradministration_lll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Useradministration_lll.Location = new System.Drawing.Point(12, 93);
            this.Useradministration_lll.Name = "Useradministration_lll";
            this.Useradministration_lll.Size = new System.Drawing.Size(101, 16);
            this.Useradministration_lll.TabIndex = 1;
            this.Useradministration_lll.TabStop = true;
            this.Useradministration_lll.Text = "Userverwaltung";
            // 
            // InvNo_lbl
            // 
            this.InvNo_lbl.AutoSize = true;
            this.InvNo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvNo_lbl.Location = new System.Drawing.Point(147, 13);
            this.InvNo_lbl.Name = "InvNo_lbl";
            this.InvNo_lbl.Size = new System.Drawing.Size(53, 16);
            this.InvNo_lbl.TabIndex = 2;
            this.InvNo_lbl.Text = "Inv-Nr.";
            // 
            // Titel_lbl
            // 
            this.Titel_lbl.AutoSize = true;
            this.Titel_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel_lbl.Location = new System.Drawing.Point(270, 13);
            this.Titel_lbl.Name = "Titel_lbl";
            this.Titel_lbl.Size = new System.Drawing.Size(39, 16);
            this.Titel_lbl.TabIndex = 3;
            this.Titel_lbl.Text = "Titel";
            // 
            // Author_lbl
            // 
            this.Author_lbl.AutoSize = true;
            this.Author_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_lbl.Location = new System.Drawing.Point(375, 13);
            this.Author_lbl.Name = "Author_lbl";
            this.Author_lbl.Size = new System.Drawing.Size(44, 16);
            this.Author_lbl.TabIndex = 4;
            this.Author_lbl.Text = "Autor";
            // 
            // Publisher_lbl
            // 
            this.Publisher_lbl.AutoSize = true;
            this.Publisher_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_lbl.Location = new System.Drawing.Point(489, 13);
            this.Publisher_lbl.Name = "Publisher_lbl";
            this.Publisher_lbl.Size = new System.Drawing.Size(54, 16);
            this.Publisher_lbl.TabIndex = 5;
            this.Publisher_lbl.Text = "Verlag";
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_lbl.Location = new System.Drawing.Point(623, 13);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(51, 16);
            this.Status_lbl.TabIndex = 6;
            this.Status_lbl.Text = "Status";
            // 
            // Condition_lbl
            // 
            this.Condition_lbl.AutoSize = true;
            this.Condition_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition_lbl.Location = new System.Drawing.Point(744, 13);
            this.Condition_lbl.Name = "Condition_lbl";
            this.Condition_lbl.Size = new System.Drawing.Size(63, 16);
            this.Condition_lbl.TabIndex = 7;
            this.Condition_lbl.Text = "Zustand";
            // 
            // Search_txb
            // 
            this.Search_txb.Location = new System.Drawing.Point(917, 28);
            this.Search_txb.Name = "Search_txb";
            this.Search_txb.Size = new System.Drawing.Size(122, 20);
            this.Search_txb.TabIndex = 8;
            this.Search_txb.Text = "Suche";
            this.Search_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 536);
            this.dataGridView1.TabIndex = 9;
            // 
            // Library_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_txb);
            this.Controls.Add(this.Condition_lbl);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.Publisher_lbl);
            this.Controls.Add(this.Author_lbl);
            this.Controls.Add(this.Titel_lbl);
            this.Controls.Add(this.InvNo_lbl);
            this.Controls.Add(this.Useradministration_lll);
            this.Controls.Add(this.Bookadministration_lll);
            this.Name = "Library_Admin";
            this.Text = "Bücherübersicht Adm.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Bookadministration_lll;
        private System.Windows.Forms.LinkLabel Useradministration_lll;
        private System.Windows.Forms.Label InvNo_lbl;
        private System.Windows.Forms.Label Titel_lbl;
        private System.Windows.Forms.Label Author_lbl;
        private System.Windows.Forms.Label Publisher_lbl;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Label Condition_lbl;
        private System.Windows.Forms.TextBox Search_txb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

