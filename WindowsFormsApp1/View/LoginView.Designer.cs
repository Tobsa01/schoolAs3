namespace WindowsFormsApp1.View
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_tbox = new System.Windows.Forms.TextBox();
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.register_linkLabel = new System.Windows.Forms.LinkLabel();
            this.logInBtn = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // username_tbox
            // 
            this.username_tbox.Location = new System.Drawing.Point(83, 206);
            this.username_tbox.Name = "username_tbox";
           // this.username_tbox.PlaceholderText = "Username";
            this.username_tbox.Size = new System.Drawing.Size(222, 23);
            this.username_tbox.TabIndex = 1;
            // 
            // password_tbox
            // 
            this.password_tbox.Location = new System.Drawing.Point(83, 244);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.PasswordChar = '*';
            //this.password_tbox.PlaceholderText = "Password";
            this.password_tbox.Size = new System.Drawing.Size(222, 23);
            this.password_tbox.TabIndex = 2;
            this.password_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tbox_KeyDown);
            // 
            // register_linkLabel
            // 
            this.register_linkLabel.AutoSize = true;
            this.register_linkLabel.Location = new System.Drawing.Point(83, 273);
            this.register_linkLabel.Name = "register_linkLabel";
            this.register_linkLabel.Size = new System.Drawing.Size(69, 15);
            this.register_linkLabel.TabIndex = 3;
            this.register_linkLabel.TabStop = true;
            this.register_linkLabel.Text = "Registrieren";
            this.register_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_linkLabel_LinkClicked);
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(230, 273);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 23);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Log in";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(83, 377);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 20);
            this.error_label.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(391, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 296);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 326);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.register_linkLabel);
            this.Controls.Add(this.password_tbox);
            this.Controls.Add(this.username_tbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginView";
            this.Text = "Clinton Bibliothek - Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginView_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox username_tbox;
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.LinkLabel register_linkLabel;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

