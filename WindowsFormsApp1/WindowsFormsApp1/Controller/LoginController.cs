using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public class LoginController : IController
    {
        private WindowsFormsApp1.View.LoginView View { get; }
        public WindowsFormsApp1.Model.LoginModel Model { get; }

        public LoginController()
        {
            Model = new WindowsFormsApp1.Model.LoginModel();
            View = new WindowsFormsApp1.View.LoginView(this);
        }

        public void HideForm()
        {
            View.HideForm();
        }

        public void ShowForm()
        {
            View.ShowForm();
        }

        public void ClearForm()
        {
            View.ClearForm();
        }

        public void CloseProgram()
        {
            var mainController = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.MainController>();
            mainController.CloseForm();
        }

        public void IsLoginCorrect(string username, string password)
        {
            //Model.AddUserToDictionary();
            //Model.AddUserToAdminList();
            string userListPassword = "";
            if (Model.Userlist.TryGetValue(username, out userListPassword))
            {
                if (password == userListPassword)
                {
                    if (IsAdmin(username))
                    {
                        HideForm();
                        var admin = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.AdminController>();
                        admin.ShowForm();
                        
                    }
                    else
                    {
                        HideForm();
                        var user = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.UserController>();
                        user.ShowForm();
                    }
                }
                else
                {
                    View.SetErrorLabel("Username or Password is incorrect!");
                }
            }
        }

        public bool IsAdmin(string username)
        {
            foreach (var user in Model.Adminlist)
            {
                if (user == username)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsEnterKey(KeyEventArgs prop)
        {
            return prop.KeyCode == Keys.Enter;
        }

    }
}
