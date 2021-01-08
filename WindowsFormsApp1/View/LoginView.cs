using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class LoginView : Form
    {
        private LoginController Controller { get; }
        private WindowsFormsApp1.Model.LoginModel Model { get; }

        public LoginView(WindowsFormsApp1.LoginController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            Model = Controller.Model;
            
        }

        public void HideForm()
        {
            Hide();
        }

        public void ShowForm()
        {
            Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Controller.IsLoginCorrect(username_tbox.Text, password_tbox.Text);
        }

        public void SetErrorLabel(string message)
        {
            error_label.Text = message;
        }

        public void ClearForm()
        {
            password_tbox.Text = "";
            username_tbox.Text = "";
            this.Select();
            this.Focus();
        }

        private void password_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Controller.IsEnterKey(e))
            {
                Controller.IsLoginCorrect(username_tbox.Text, password_tbox.Text);
            }
        }

        private void LoginView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.CloseProgram();
        }
    }
}
