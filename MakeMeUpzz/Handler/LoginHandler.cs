using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class LoginHandler
    {
        public static User GetUserHandler(string email, string password)
        {
            return UserRepository.loginUser(email, password);
        }

        public static string getEmail(int ID)
        {
            return UserRepository.getCurrentUser(ID).UserEmail;
        }

        public static string getPassword(int ID)
        {
            return UserRepository.getCurrentUser(ID).UserPassword;
        }
    }
}