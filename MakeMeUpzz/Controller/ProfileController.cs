using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class ProfileController
    {
        public static Boolean checkCurr(int id, out string Username, out string Email, out string Gender, out string DOB)
        {
            User curr = ProfileHandler.getCurrentUser(id);
            Username = curr.UserEmail.ToString();
            Email = curr.Username.ToString();
            Gender = curr.UserGender.ToString();
            DOB = curr.UserDOB.ToString();

            if (curr != null)
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