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
            this.iSBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBN.Location = new System.Drawing.Point(332, 33);
            this.iSBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iSBN.Name = "iSBN";
            this.iSBN.Size = new System.Drawing.Size(43, 17);
            this.iSBN.TabIndex = 0;
            this.iSBN.Text = "ISBN";
            this.iSBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(332, 111);
            this.titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(40, 17);
            this.titel.TabIndex = 1;
            this.titel.Text = "Titel";
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(325, 75);
            this.autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(47, 17);
            this.autor.TabIndex = 2;
            this.autor.Text = "Autor";
            this.autor.Click += new System.EventHandler(this.label3_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(265, 268);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(107, 17);
            this.description.TabIndex = 3;
            this.description.Text = "Beschreibung";
            this.description.Click += new System.EventHandler(this.label4_Click);
            // 
            // inventory
            // 
            this.inventory.AutoSize = true;
            this.inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(241, 222);
            this.inventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(131, 17);
            this.inventory.TabIndex = 4;
            this.inventory.Text = "Inventar Nummer";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.Location = new System.Drawing.Point(305, 182);
            this.condition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(67, 17);
            this.condition.TabIndex = 5;
            this.condition.Text = "Zustand";
            this.condition.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 6;
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher.Location = new System.Drawing.Point(317, 144);
            this.publisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(55, 17);
            this.publisher.TabIndex = 7;
            this.publisher.Text = "Verlag";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(380, 33);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(631, 22);
            this.txtISBN.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(380, 75);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(631, 22);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtInventoryNumber
            // 
            this.txtInventoryNumber.Location = new System.Drawing.Point(380, 222);
            this.txtInventoryNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInventoryNumber.Name = "txtInventoryNumber";
            this.txtInventoryNumber.Size = new System.Drawing.Size(631, 22);
            this.txtInventoryNumber.TabIndex = 10;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(380, 182);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(631, 22);
            this.txtCondition.TabIndex = 11;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(380, 144);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(631, 22);
            this.txtPublisher.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(380, 111);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(631, 22);
            this.txtTitle.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(380, 268);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(631, 179);
            this.txtDescription.TabIndex = 14;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(912, 495);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 28);
            this.Save.TabIndex = 15;
            this.Save.Text = "Speichern";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(804, 495);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Abbrechen";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBookView";
            this.Text = "AddBookView";
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