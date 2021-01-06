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
        private Books oldBook;
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
        public void updateBook(Books b)
        {
            View.updateBook(b);
            oldBook = b;
        }
        public void update(string author, string condition, string description, string inventarnr, string isbn, string publisher, string title)
        {
            Books newBook = new Books
            {
                Author = author,
                Condition = condition,
                Desription = description,
                Inventar_Number = inventarnr,
                ISBN = isbn,
                Publisher = publisher,
                Title = title
            };
            BookAdminModel.update_Book(oldBook, newBook);
            View.HideForm();
            var bookView = ControllerManager.Get<BookController>();
            bookView.RefreshData();
        }
    }
}
