using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WindowsFormsApp1.Model
{
    public class UserModel
    {
        private LibratorsEntities context = new LibratorsEntities();

        public List<Users> select_User_for_Login(string email, string password)
        {
            var query = from user in context.Users
                        where user.EMailAddress == email && user.EncryptedPW == password
                        select user;

            return query.ToList();
        }

        public void insert_User(string lastName, string firstName, string email, int MANumber, string role, string password)
        {
            Users user = new Users
            {
                LastName = lastName,
                FirstName = firstName,
                EMailAddress = email,
                MANumber = MANumber,
                Rolle = role,
                EncryptedPW = password
            };
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void update_User(string lastName, string firstName, string email, int MANumber, string role, string password)
        {
            Users user = context.Users.Where(u => u.MANumber == MANumber).First();
            user.LastName = lastName;
            user.FirstName = firstName;
            user.EMailAddress = email;
            user.MANumber = MANumber;
            user.Rolle = role;
            user.EncryptedPW = password;
            context.SaveChanges();
        }

        public void delete_User(int MANumber)
        {
            Users user = context.Users.Where(u => u.MANumber == MANumber).First();
            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
