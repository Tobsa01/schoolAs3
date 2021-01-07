namespace WindowsFormsApp1.View
{
    partial class AddUserView
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtEmailAdress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMANumber = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.eMailAdress = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.MANumber = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(297, 69);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(717, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(213, 69);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(72, 17);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "Vorname";
            this.firstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(297, 121);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(717, 22);
            this.txtLastname.TabIndex = 2;
            // 
            // txtEmailAdress
            // 
            this.txtEmailAdress.Location = new System.Drawing.Point(297, 169);
            this.txtEmailAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailAdress.Name = "txtEmailAdress";
            this.txtEmailAdress.Size = new System.Drawing.Size(717, 22);
            this.txtEmailAdress.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(297, 221);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(717, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtMANumber
            // 
            this.txtMANumber.Location = new System.Drawing.Point(297, 265);
            this.txtMANumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMANumber.Name = "txtMANumber";
            this.txtMANumber.Size = new System.Drawing.Size(717, 22);
            this.txtMANumber.TabIndex = 5;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(201, 121);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(84, 17);
            this.lastName.TabIndex = 6;
            this.lastName.Text = "Nachname";
            this.lastName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // eMailAdress
            // 
            this.eMailAdress.AutoSize = true;
            this.eMailAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMailAdress.Location = new System.Drawing.Point(158, 169);
            this.eMailAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eMailAdress.Name = "eMailAdress";
            this.eMailAdress.Size = new System.Drawing.Size(127, 17);
            this.eMailAdress.TabIndex = 7;
            this.eMailAdress.Text = "E-Mail-Addresse";
            this.eMailAdress.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(212, 221);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 17);
            this.password.TabIndex = 8;
            this.password.Text = "Passwort";
            // 
            // MANumber
            // 
            this.MANumber.AutoSize = true;
            this.MANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANumber.Location = new System.Drawing.Point(135, 265);
            this.MANumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MANumber.Name = "MANumber";
            this.MANumber.Size = new System.Drawing.Size(150, 17);
            this.MANumber.TabIndex = 9;
            this.MANumber.Text = "Mitarbeiter Nummer";
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(187, 323);
            this.admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(98, 17);
            this.admin.TabIndex = 10;
            this.admin.Text = "Adminzugriff";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(916, 497);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chIsAdmin
            // 
            this.chIsAdmin.AutoSize = true;
            this.chIsAdmin.Location = new System.Drawing.Point(297, 324);
            this.chIsAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chIsAdmin.Name = "chIsAdmin";
            this.chIsAdmin.Size = new System.Drawing.Size(18, 17);
            this.chIsAdmin.TabIndex = 12;
            this.chIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(808, 497);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chIsAdmin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.MANumber);
            this.Controls.Add(this.password);
            this.Controls.Add(this.eMailAdress);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.txtMANumber);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmailAdress);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.txtFirstName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddUserView";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.label1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtEmailAdress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMANumber;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label eMailAdress;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label MANumber;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chIsAdmin;
        private System.Windows.Forms.Button btnCancel;
    }
}