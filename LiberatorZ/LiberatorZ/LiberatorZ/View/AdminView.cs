using System;
using System.Windows.Forms;
using LiberatorZ.Controller;
using LiberatorZ.Model;

namespace LiberatorZ.View
{
    public partial class AdminView : Form
    {
        private AdminController Controller { get; }
        private AdminModel Model { get; }
        public AdminView(AdminController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            Model = Controller.Model;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Controller.Logout();
        }

        public void HideForm()
        {
            Hide();
        }

        public void ShowForm()
        {
            Show();
        }

        private void AdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.CloseProgram();
        }
    }
}
