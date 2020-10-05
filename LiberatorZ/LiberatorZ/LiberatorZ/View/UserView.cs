using System.Windows.Forms;
using LiberatorZ.Controller;
using LiberatorZ.Model;

namespace LiberatorZ.View
{
    public partial class UserView : Form
    {
        private UserController Controller { get; }
        private UserModel Model { get; }
        public UserView(UserController controller)
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

        private void logoutBtn_Click(object sender, System.EventArgs e)
        {
            Controller.Logout();
        }

        private void UserView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.CloseProgram();
        }
    }
}
