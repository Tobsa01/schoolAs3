using System;
using System.Collections.Generic;
using System.Text;

namespace LiberatorZ.Model
{
    public class LoginModel
    {
        public LoginModel()
        {
            AddUserToAdminList();
            AddUserToDictionary();
        }

        public Dictionary<string, string> Userlist = new Dictionary<string, string>();

        public List<string> Adminlist = new List<string>();
        public void AddUserToDictionary()
        {
            Userlist.Add("user", "123");
            Userlist.Add("admin", "123");
        }

        public void AddUserToAdminList()
        {
            Adminlist.Add("admin");
        }
    }
}
