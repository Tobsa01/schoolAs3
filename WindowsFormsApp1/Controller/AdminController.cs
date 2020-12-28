using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class AdminController : IController
    {
        private AdminView View { get; }
        public WindowsFormsApp1.Model.AdminModel Model { get; }

        public AdminController()
        {
            Model = new WindowsFormsApp1.Model.AdminModel();
            View = new AdminView(this);
        }

        public void Logout()
        {
            var loginController = ControllerManager.Get<LoginController>();
            HideForm();
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
    }
}
