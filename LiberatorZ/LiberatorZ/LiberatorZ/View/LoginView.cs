using System.Diagnostics;
using System.Windows.Forms;
using LiberatorZ.Controller;
using LiberatorZ.Model;

namespace LiberatorZ
{
    public partial class LoginView : Form
    {
        private LoginController Controller { get; }
        private LoginModel Model { get; }

        public LoginView(LoginController controller)
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

        private void register_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://www.google.de",
                UseShellExecute = true 
            };
            Process.Start(psi);
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
