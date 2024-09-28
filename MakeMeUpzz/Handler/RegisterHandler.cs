using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class RegisterHandler
    {
        public static bool checkEmail(string email)
        {
            return UserRepository.checkEmail(email);
        }
        public static void insertUser(string userName, string userEmail, string userPassword, string userGender, DateTime userDOB)
        {
            UserRepository.insertNewUser(userName, userEmail, userPassword, userGender, userDOB);
        }
    }
}