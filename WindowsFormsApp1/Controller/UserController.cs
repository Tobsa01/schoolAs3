using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class UserController : IController
    {
        private Useradministration View { get; }
        public UserModel Model { get; }

        public UserController()
        {
            Model = new UserModel();
            View = new Useradministration(this);
        }

        public void Logout()
        {
            HideForm();
            var loginController = ControllerManager.Get<LoginController>();
            loginController.ClearForm();
            loginController.ShowForm();
        }

        public void CloseProgram()
        {
            var mainController = ControllerManager.Get<MainController>();
            mainController.CloseForm();
        }

        public void HideForm()
        {
            View.HideForm();
        }

        public void ShowForm()
        {
            View.ShowForm();
        }

        public void Back()
        {
            HideForm();
            var admin = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.AdminController>();
            admin.ShowForm();
        }
        public void Add()
        {
            var addUserController = ControllerManager.Get<AddUserController>();
            addUserController.ShowForm();
        }

        public void Refresh()
        {
            View.Refresh();
        }
    }
}
