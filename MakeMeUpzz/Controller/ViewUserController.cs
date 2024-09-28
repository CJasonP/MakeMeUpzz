using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class ViewUserController
    {
        public static List<User> GetAllUser()
        {
            return ViewUserHandler.GetAllUser();
        }
        public static User GetUserHandler(int id)
        {
            return ViewUserHandler.GetUserHandler(id);
        }
    }
}