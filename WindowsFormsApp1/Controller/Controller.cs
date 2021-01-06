using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    class Controller
    {
       

        UserModel model = new UserModel();
        Model.BookAdminModel modelB = new Model.BookAdminModel();

        public void login(string email, string password)
        {
            Users user = UserModel.select_User_for_Login(email, password);
            CurrentUser.setCurrentUser(user);
        }

        public void add_User(string lastName, string firstName, string email, int MANumber, string role, string password)
        {
            UserModel.insert_User(lastName, firstName, email, MANumber, role, password);
        }

        public void add_Book(string author, string condition, string description, string inventarnr, string isbn, string publisher, string x)
        {
            BookAdminModel.insert_Book(author, condition, description, inventarnr, isbn, publisher, x);
        }
    }
}
