using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Controller
{
    public class BookAdminController : IController
    {
        private BookAdminView View { get; }
        public BookAdminModel Model { get; }

        public BookAdminController()
        {
            Model = new BookAdminModel();
            View = new BookAdminView(this);
        }
    }
}
