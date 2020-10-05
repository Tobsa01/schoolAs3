using LiberatorZ.Model;
using LiberatorZ.View;

namespace LiberatorZ.Controller
{
    class MainController : IController
    {
        private MainView View { get; }
        public MainModel Model { get; }

        public MainController(MainView view)
        {
            View = view;
            Model = new MainModel();
            ControllerManager.Register(this);
            ControllerManager.Register(new AdminController());
            ControllerManager.Register(new LoginController());
            ControllerManager.Register(new UserController());
            OnStart();
        }

        public void OnStart()
        {
            var loginController = ControllerManager.Get<LoginController>();
            loginController.ClearForm();
            loginController.ShowForm();
        }

        public void CloseForm()
        {
            View.CloseForm();
        }
    }
}
