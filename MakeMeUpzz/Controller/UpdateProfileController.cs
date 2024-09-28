using MakeMeUpzz.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class UpdateProfileController
    {
        public static Boolean updateProfile(string email, string name, string gender, int id, DateTime dob)
        {
            if (email == String.Empty || name == String.Empty || gender == String.Empty)
            {
                return false;
            }
            else if (UpdateProfileHandler.CheckExistingEmail(email) == false)
            {
                return false;
            }

            UpdateProfileHandler.UpdateProfile(id, name, gender, email, dob);
            return true;
        }

    }
}