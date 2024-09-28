using MakeMeUpzz.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class RegisterController
    {
        public static bool registerComplete(string email, string username, string password, string confirm, string gender, DateTime dob,out string errorMessage)
        {
            if (string.IsNullOrEmpty(email))
            {
                errorMessage = "Email must be filled";
                return false;
            }
            if (RegisterHandler.checkEmail(email))
            {
                errorMessage = "Email must be unique";
                return false;
            }
            if (string.IsNullOrEmpty(username))
            {
                errorMessage = "Name must be filled";
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorMessage = "Password must be filled";
                return false;
            }
            if (string.IsNullOrEmpty(confirm))
            {
                errorMessage = "Confirmation password must be filled";
                return false;
            }
            if (password != confirm)
            {
                errorMessage = "Confirmation password must match password";
                return false;
            }
            if (string.IsNullOrEmpty(gender))
            {
                errorMessage = "Gender must be chosen";
                return false;
            }

            RegisterHandler.insertUser(username, email, password, gender, dob);
            errorMessage = string.Empty;
            return true;
        }

    }
}