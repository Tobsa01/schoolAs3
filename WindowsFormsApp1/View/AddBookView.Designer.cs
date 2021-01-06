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
            this.inventory = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtInventoryNumber = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iSBN
            // 
            this.iSBN.AutoSize = true;
            this.iSBN.Location = new System.Drawing.Point(238, 34);
            this.iSBN.Name = "iSBN";
            this.iSBN.Size = new System.Drawing.Size(32, 13);
            this.iSBN.TabIndex = 0;
            this.iSBN.Text = "ISBN";
            this.iSBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Location = new System.Drawing.Point(243, 93);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(27, 13);
            this.titel.TabIndex = 1;
            this.titel.Text = "Titel";
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(238, 64);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(32, 13);
            this.autor.TabIndex = 2;
            this.autor.Text = "Autor";
            this.autor.Click += new System.EventHandler(this.label3_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(198, 221);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(72, 13);
            this.description.TabIndex = 3;
            this.description.Text = "Beschreibung";
            this.description.Click += new System.EventHandler(this.label4_Click);
            // 
            // inventory
            // 
            this.inventory.AutoSize = true;
            this.inventory.Location = new System.Drawing.Point(182, 183);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(88, 13);
            this.inventory.TabIndex = 4;
            this.inventory.Text = "Inventar Nummer";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Location = new System.Drawing.Point(224, 151);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(46, 13);
            this.condition.TabIndex = 5;
            this.condition.Text = "Zustand";
            this.condition.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Location = new System.Drawing.Point(195, 120);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(75, 13);
            this.publisher.TabIndex = 7;
            this.publisher.Text = "Veröffentlicher";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(285, 27);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(474, 20);
            this.txtISBN.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(285, 61);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(474, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtInventoryNumber
            // 
            this.txtInventoryNumber.Location = new System.Drawing.Point(285, 180);
            this.txtInventoryNumber.Name = "txtInventoryNumber";
            this.txtInventoryNumber.Size = new System.Drawing.Size(474, 20);
            this.txtInventoryNumber.TabIndex = 10;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(285, 148);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(474, 20);
            this.txtCondition.TabIndex = 11;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(285, 117);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(474, 20);
            this.txtPublisher.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(285, 90);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(474, 20);
            this.txtTitle.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(285, 218);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(474, 146);
            this.txtDescription.TabIndex = 14;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(684, 402);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "Speichern";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(603, 402);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Abbrechen";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtInventoryNumber);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.inventory);
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
        private System.Windows.Forms.Label inventory;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtInventoryNumber;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button cancel;
    }
}