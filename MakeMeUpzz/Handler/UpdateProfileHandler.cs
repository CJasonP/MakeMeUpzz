using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class UpdateProfileHandler
    {
        public static void UpdateProfile(int id, string name, string email, string gender, DateTime dob)
        {
            UserRepository.updateUser(id, name, email, gender, dob);
        }

        public static bool CheckExistingEmail(string email)
        {
            return UserRepository.checkEmail(email);
        }
    }
}