using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller
{
    class Controller
    {
        UsersModel model = new UsersModel();

        public void login(string email, string password)
        {
            Users user = UsersModel.select_User_for_Login(email, password);
            CurrentUser.setCurrentUser(user);
        }

        public void add_User(string lastName, string firstName, string email, int MANumber, string role, string password)
        {
            UsersModel.insert_User(lastName, firstName, email, MANumber, role, password);
        }
    }
}
