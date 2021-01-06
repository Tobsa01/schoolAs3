using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    public class AddBookController: IController
    {
        private AddBookView View;
        public AddBookController()
        {
            View = new AddBookView(this);
        }
        public void save(string author, string condition, string description, string inventarnr, string isbn, string publisher, string title)
        {
            BookAdminModel.insert_Book(author, condition, description, inventarnr, isbn, publisher, title);
            close();
        }
        public void ShowForm()
        {
            View.ShowForm();
        }
        public void close()
        {
            View.HideForm();
            var bookView = ControllerManager.Get<BookController>();
            bookView.RefreshData();
        }
    }
}
