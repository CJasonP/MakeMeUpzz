using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class ViewMakeupController
    {
        public static List<Makeup> GetAllMakeup()
        {
            return ViewMakeupHandler.getAllMakeup();
        }
        public static void removeMakeup(int makeupId)
        {
            ViewMakeupHandler.deleteMakeup(makeupId);
        }

    }
}