using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class ViewUserHandler
    {
        public static List<User> GetAllUser()
        {
            return UserRepository.GetAllUsers();
        }
        public static User GetUserHandler(int id)
        {
            return UserRepository.getCurrentUser(id);
        }
    }
}