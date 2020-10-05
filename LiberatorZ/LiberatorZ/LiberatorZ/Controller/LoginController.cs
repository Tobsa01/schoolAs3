using System.Windows.Forms;
using LiberatorZ.Model;

namespace LiberatorZ.Controller
{
    public class LoginController : IController
    {
        private LoginView View { get; }
        public LoginModel Model { get; }

        public LoginController()
        {
            Model = new LoginModel();
            View = new LoginView(this);
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
            var mainController = ControllerManager.Get<MainController>();
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
                        var admin = ControllerManager.Get<AdminController>();
                        admin.ShowForm();
                        
                    }
                    else
                    {
                        HideForm();
                        var user = ControllerManager.Get<UserController>();
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
