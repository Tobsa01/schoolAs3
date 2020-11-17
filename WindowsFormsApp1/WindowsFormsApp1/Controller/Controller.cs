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
        Model_deprecated model = new Model_deprecated();

        public void login(string email, string password)
        {
            // ToDo: Passwort verschlüsseln
            List<Users> user = model.select_User_for_Login(email, password);
            if (user.Count == 0)
            {
                // ToDo: Kein Nutzer mit diesen Credentials vorhanden
            }
            else if (user.Count == 1)
            {
                // ToDo: Login
            }
            else
            {
                // ToDo: Credentials nicht eindeutig
            }
        }

        public void add_User(string lastName, string firstName, string email, int MANumber, string role, string password)
        {
            model.insert_User(lastName, firstName, email, MANumber, role, password);
        }
    }
}
