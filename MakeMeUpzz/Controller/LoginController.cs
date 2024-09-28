using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class LoginController
    {
        public static User checkLogin(string email, string password, out string errorMessage)
        {
            errorMessage = "";
            User checkUser = LoginHandler.GetUserHandler(email, password);
            if (checkUser == null)
            {
                errorMessage = "User not found";
            }
            return checkUser;
        }
        public static string getEmail(int ID)
        {
            return LoginHandler.getEmail(ID);
        }

        public static string getPassword(int ID)
        {
            return LoginHandler.getPassword(ID);
        }
    }
}