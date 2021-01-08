using System;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class AdminController : IController
    {
        private Library_Admin View { get; }
        public WindowsFormsApp1.Model.AdminModel Model { get; }

        public AdminController()
        {
            Model = new WindowsFormsApp1.Model.AdminModel();
            View = new Library_Admin(this);
        }

        public void Buecher()
        {
            HideForm();
            var buecher = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.BookController>();
            buecher.ShowForm();
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
            Application.Exit();
        }

        public void HideForm()
        {
            View.HideForm();
        }

        public void ShowForm()
        {
            View.ShowForm();
        }


        internal void User()
        {
            HideForm();
            var user = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.UserController>();
            user.ShowForm();
        }
    }
}
