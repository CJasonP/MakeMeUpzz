using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class UpdatePasswordHandler
    {
        public static User getCurrentUser(int userId)
        {
            return UserRepository.getCurrentUser(userId);
        }
        public static Boolean updatePassword(int id, string newPassword)
        {
            return UserRepository.updatePassword(id, newPassword);
        }
    }
}