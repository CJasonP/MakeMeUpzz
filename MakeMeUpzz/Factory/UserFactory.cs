using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class UserFactory
    {
        public static User createUser(string userName, string userEmail, DateTime userDOB, string userGender, string userPassword)
        {
            User user = new User();
            //user.UserID = userId;
            user.Username = userName;
            user.UserEmail = userEmail;
            user.UserDOB = userDOB;
            user.UserGender = userGender;
            //user.UserRole = userRole;
            user.UserPassword = userPassword;
            return user;
        }
    }
}