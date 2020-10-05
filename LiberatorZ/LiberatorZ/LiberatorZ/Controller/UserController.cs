using LiberatorZ.Model;
using LiberatorZ.View;

namespace LiberatorZ.Controller
{
    public class UserController : IController
    {
        private UserView View { get; }
        public UserModel Model { get; }

        public UserController()
        {
            Model = new UserModel();
            View = new UserView(this);
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
    }
}
