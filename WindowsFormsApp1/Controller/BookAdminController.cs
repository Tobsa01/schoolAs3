using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Controller
{
    public class BookAdminController : IController
    {
        public BookAdminView View { get; }
        public BookAdminModel Model { get; }

        public BookAdminController()
        {
            Model = new BookAdminModel();
            View = new BookAdminView(this);
        }


        public void HideForm()
        {

           View.HideForm();
        }

        public void ShowForm()
        {
            View.ShowForm();
        }

       
        public void CloseProgram()
        {
            var mainController = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.MainController>();
            mainController.CloseForm();
        }

    }
}
