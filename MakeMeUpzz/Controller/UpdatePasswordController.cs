using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class UpdatePasswordController
    {
        public static Boolean updatePassword(int id, string newPassword)
        {
            UpdatePasswordHandler.updatePassword(id, newPassword);
            return true;
        }
        public static Boolean checkExistUserId(int id, out string userPassword)
        {
            User user = UpdatePasswordHandler.getCurrentUser(id);
            userPassword = user.UserPassword.ToString();
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}