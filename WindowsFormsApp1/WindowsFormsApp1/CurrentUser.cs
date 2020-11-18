using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CurrentUser: Users
    {
        private static Users instance = null;
        private CurrentUser(){}
        public static Users getInstance()
        {
            if(instance == null)
            {
                instance = new CurrentUser();
            } return instance;
        }
        public static bool getAdmin()
        {
            return instance.Rolle == "adm";
        }
        public static int getUserId()
        {
            return instance.UserID;
        }
        public static int getMANumber()
        {
            return instance.MANumber;
        }
        public static void setCurrentUser(Users user)
        {
            instance = user;
        }
    }
}
