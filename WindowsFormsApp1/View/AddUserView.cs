using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.View
{
    public partial class AddUserView : Form
    {
        private AddUserController Controller;
        private static bool editMode = false;
        public AddUserView(AddUserController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            this.FormClosing += new FormClosingEventHandler(Form_Closing);
        }
        public void HideForm()
        {
            editMode = false;
            this.eMailAdress.ForeColor = default(Color);
            this.firstName.ForeColor = default(Color);
            this.lastName.ForeColor = default(Color);
            this.MANumber.ForeColor = default(Color);
            this.txtMANumber.BackColor = default(Color); 
            this.password.ForeColor = default(Color); 
            this.txtMANumber.ReadOnly = false;
            this.MANumber.BackColor = default(Color);
            this.txtEmailAdress.Text = "";
            this.txtFirstName.Text = "";
            this.txtLastname.Text = "";
            this.txtMANumber.Text = "";
            this.txtPassword.Text = "";
            Hide();
        }

        public void ShowForm()
        {
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkInputFields() && !editMode)
            {
                Controller.save(this.txtLastname.Text, this.txtFirstName.Text, this.txtEmailAdress.Text, Int32.Parse(this.txtMANumber.Text), this.chIsAdmin.Checked, this.txtPassword.Text);
            } else if (checkInputFields() && editMode) {
                Controller.Update(this.txtLastname.Text, this.txtFirstName.Text, this.txtEmailAdress.Text, Int32.Parse(this.txtMANumber.Text), this.chIsAdmin.Checked, this.txtPassword.Text);
            }
        }
        public void UpdateUser(Users user)
        {
            editMode = true;
            this.txtEmailAdress.Text = user.EMailAddress;
            this.txtFirstName.Text = user.FirstName;
            this.txtLastname.Text = user.LastName;
            this.txtMANumber.Text = user.MANumber.ToString();
            this.txtMANumber.ReadOnly = true;
            this.txtMANumber.BackColor = Color.Gray;
            this.txtPassword.Text = user.EncryptedPW;
            this.chIsAdmin.Checked = user.Rolle == "adm";
            Show();
        }
        private bool checkInputFields()
        {
            bool intIsParsable = Int32.TryParse(this.txtMANumber.Text, out int n);
            this.eMailAdress.ForeColor = Color.Black;
            this.firstName.ForeColor = Color.Black;
            this.lastName.ForeColor = Color.Black;
            this.MANumber.ForeColor = Color.Black;
            this.password.ForeColor = Color.Black;
            if (this.txtEmailAdress.Text == "") this.eMailAdress.ForeColor = Color.Red;
            if (this.txtFirstName.Text == "") this.firstName.ForeColor = Color.Red;
            if (this.txtLastname.Text == "") this.lastName.ForeColor = Color.Red;
            if (this.txtMANumber.Text == "" || !intIsParsable) this.MANumber.ForeColor = Color.Red;
            if (this.txtPassword.Text == "") this.password.ForeColor = Color.Red;
            return this.txtEmailAdress.Text != "" && this.txtFirstName.Text != "" && this.txtLastname.Text != "" && this.txtMANumber.Text != "" && this.txtPassword.Text != "" && intIsParsable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.close();
        }
        private void Form_Closing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            HideForm();
        }
    }
}
