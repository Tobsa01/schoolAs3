using LiberatorZ.Model;
using LiberatorZ.View;

namespace LiberatorZ.Controller
{
    public class AdminController : IController
    {
        private AdminView View { get; }
        public AdminModel Model { get; }

        public AdminController()
        {
            Model = new AdminModel();
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
