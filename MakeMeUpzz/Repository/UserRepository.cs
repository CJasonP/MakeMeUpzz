using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class UserRepository
    {
        static MakeMeUpzzDBEntities db = new MakeMeUpzzDBEntities();
        public static void insertNewUser(string username, string email, string gender, string password, DateTime dob)
        {
            User newUser = UserFactory.createUser(username, email, dob, password, gender);
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public static List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public static Boolean updatePassword(int userId, string password)
        {
            User user = db.Users.Where(a => a.UserID == userId).FirstOrDefault();
            user.UserPassword = password;
            db.SaveChanges();
            return true;
        }

        public static void updateUser(int userId, string username, string email, string gender, DateTime dob)
        {
            User user = db.Users.Where(a => a.UserID == userId).FirstOrDefault();
            user.Username = username;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = dob;
            db.SaveChanges();
        }
        
        public static User loginUser(string username, string password)
        {
            return (from User in db.Users
                    where User.Username == username
                    && User.UserPassword == password
                    select User).FirstOrDefault();
        }

        public static User getCurrentUser(int id)
        {
            User data = (from User in db.Users
                         where User.UserID == id
                         select User).FirstOrDefault();
            return data;
        }
 
        public static bool checkEmail(string email)
        {
            if (db.Users.Where(a => a.UserEmail == email).FirstOrDefault() != null) return true;
            return false;
        }

        public static string getUserObj(object user)
        {
            var tempUser = getCurrentUser(((User)user).UserID);
            return tempUser.UserRole;
        }


    }
}