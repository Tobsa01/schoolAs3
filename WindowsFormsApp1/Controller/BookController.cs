using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class BookController : IController
    {
        private Bookadministration View { get; }
        public WindowsFormsApp1.Model.BookAdminModel Model { get; }

        public BookController()
        {
            Model = new BookAdminModel();
            View = new Bookadministration(this);
        }

        public void ShowForm()
        {
            View.ShowForm();
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

        public void Back()
        {
            HideForm();
            var admin = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.AdminController>();
            admin.ShowForm();
        }
    }
}
