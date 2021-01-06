using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class AddUserController : IController
    {
        private AddUserView View;
        public AddUserController()
        {
            View = new AddUserView(this);
        }
        public void save(string lastName, string firstName, string email, int MANumber, bool isAdmin, string password)

        {
            string adm = "usr";
            if (isAdmin) adm = "adm";
            UserModel.insert_User(lastName, firstName, email, MANumber, adm, password);
            close();
        }
        public void ShowForm()
        {
            View.ShowForm();
        }
        public void close()
        {
            View.HideForm();
            var userView = ControllerManager.Get<UserController>();
            userView.RefreshData();
        } 
        
    }
}
