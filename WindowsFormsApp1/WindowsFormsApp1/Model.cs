using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Model_deprecated
    {
        LibratorsEntities context = new LibratorsEntities();

        public List<Users> select_User_for_Login(string email, string password)
        {
            var query = from user in context.Users
                        where user.EMailAddress == email && user.EncryptedPW == password
                        select user;

            return query.ToList();
        }

        public void insert_User(string lastName, string firstName, string email, int MANumber, string role, string password)
        {
            Users user = new Users();
            user.LastName = lastName;
            user.FirstName = firstName;
            user.EMailAddress = email;
            user.MANumber = MANumber;
            user.Rolle = role;
            user.EncryptedPW = password;
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
