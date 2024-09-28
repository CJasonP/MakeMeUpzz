using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class ProfileHandler
    {
        public static User getCurrentUser(int userId)
        {
            return UserRepository.getCurrentUser(userId);
        }
    }
}