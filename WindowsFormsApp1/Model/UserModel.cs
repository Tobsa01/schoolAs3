﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public class UserModel
    {
        /*private LibratorsEntities context = new LibratorsEntities();

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
        }*/


        private static LibratorsEntities context = new LibratorsEntities();
        static SHA256 sha256 = SHA256.Create();
        private static string salt = "LibaratorZ";

        public static Users select_User_for_Login(string email, string password)
        {
            Users res = new Users();
            string encryptedPassword = passwordGenerator(password);
            var query = from user in context.Users
                        where user.EMailAddress == email && user.EncryptedPW == encryptedPassword
                        select user;
            if (query.ToList().Count == 1)
            {
                return query.ToList()[0];
            }
            return res;
        }

        public static Users selectUserWithId(int userId)
        {
            Users user = context.Users.Where(u => userId == u.UserID).First();
            return user;
        }
        public static void insert_User(string lastName, string firstName, string email, int MANumber, string role, string password)
        {
            Users user = new Users();
            user.LastName = lastName;
            user.FirstName = firstName;
            user.EMailAddress = email;
            user.MANumber = MANumber;
            user.Rolle = role;
            user.EncryptedPW = passwordGenerator(password);
            context.Users.Add(user);
            context.SaveChanges();
        }

        public static void update_User(Users oldUser, Users newUser)
        {
            Users user = context.Users.Where(u => oldUser.UserID == u.UserID).First();
            user.EMailAddress = newUser.EMailAddress;
            user.LastName = newUser.LastName;
            user.FirstName = newUser.FirstName;
            user.MANumber = newUser.MANumber;
            user.Rolle = newUser.Rolle;
            if (newUser.EncryptedPW != user.EncryptedPW)
            {
                user.EncryptedPW = passwordGenerator(newUser.EncryptedPW);
            }
            context.SaveChanges();
        }

        public static void delete_User(int id)
        {
            Users user = context.Users.Where(u => u.UserID == id).First();
            if ((context.Reservations.Any(u => u.FK_UserID == id)))
            {
                context.Reservations.Remove(context.Reservations.Where(u => u.FK_UserID == id).First());
            }
            if ((context.Issues.Any(u => u.FK_UserID == id)))
            {
                context.Issues.Remove(context.Issues.Where(u => u.FK_UserID == id).First());
            }
            context.Users.Remove(user);
            context.SaveChanges();
        }
        private static string passwordGenerator(string password)
        {
            return Encoding.UTF8.GetString(sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt)));
        }
    }
}

