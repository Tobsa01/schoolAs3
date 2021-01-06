namespace WindowsFormsApp1.View
{
    partial class AddBookView
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
            this.iSBN = new System.Windows.Forms.Label();
            this.titel = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iSBN
            // 
            this.iSBN.AutoSize = true;
            this.iSBN.Location = new System.Drawing.Point(42, 34);
            this.iSBN.Name = "iSBN";
            this.iSBN.Size = new System.Drawing.Size(32, 13);
            this.iSBN.TabIndex = 0;
            this.iSBN.Text = "ISBN";
            this.iSBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Location = new System.Drawing.Point(42, 93);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(27, 13);
            this.titel.TabIndex = 1;
            this.titel.Text = "Titel";
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(42, 64);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(32, 13);
            this.autor.TabIndex = 2;
            this.autor.Text = "Autor";
            this.autor.Click += new System.EventHandler(this.label3_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(42, 225);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(72, 13);
            this.description.TabIndex = 3;
            this.description.Text = "Beschreibung";
            this.description.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // AddBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.description);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.iSBN);
            this.Name = "AddBookView";
            this.Text = "AddBookView";
            this.Load += new System.EventHandler(this.AddBookView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iSBN;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}