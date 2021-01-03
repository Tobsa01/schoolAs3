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
            this.InvNo_lbl = new System.Windows.Forms.Label();
            this.Titel_lbl = new System.Windows.Forms.Label();
            this.Author_lbl = new System.Windows.Forms.Label();
            this.Publisher_lbl = new System.Windows.Forms.Label();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.Condition_lbl = new System.Windows.Forms.Label();
            this.Search_txb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bücherverwaltung = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 264);
            this.dataGridView1.TabIndex = 9;
            // 
            // Bücherverwaltung
            // 
            this.Bücherverwaltung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bücherverwaltung.Location = new System.Drawing.Point(6, 88);
            this.Bücherverwaltung.Name = "Bücherverwaltung";
            this.Bücherverwaltung.Size = new System.Drawing.Size(121, 23);
            this.Bücherverwaltung.TabIndex = 10;
            this.Bücherverwaltung.Text = "Bücherverwaltung";
            this.Bücherverwaltung.UseVisualStyleBackColor = true;
            this.Bücherverwaltung.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Nutzerverwaltung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(133, 313);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(763, 264);
            this.dataGridView2.TabIndex = 12;
            // 
            // Library_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 589);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bücherverwaltung);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_txb);
            this.Controls.Add(this.Condition_lbl);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.Publisher_lbl);
            this.Controls.Add(this.Author_lbl);
            this.Controls.Add(this.Titel_lbl);
            this.Controls.Add(this.InvNo_lbl);
            this.Name = "Library_Admin";
            this.Text = "Übersicht Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InvNo_lbl;
        private System.Windows.Forms.Label Titel_lbl;
        private System.Windows.Forms.Label Author_lbl;
        private System.Windows.Forms.Label Publisher_lbl;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Label Condition_lbl;
        private System.Windows.Forms.TextBox Search_txb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bücherverwaltung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

