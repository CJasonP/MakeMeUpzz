using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class ViewMakeupTypeController
    {
        public static List<MakeupType> getAllMakeupTypes()
        {
            return ViewMakeupTypeHandler.getAllType();
        }
        public static string removeType(String name)
        {
            return ViewMakeupTypeHandler.removeType(name);
        }
        public static List<MakeupType> CheckMakeupType(int id)
        {
            return ViewMakeupTypeHandler.CheckMakeupType(id);
        }
    }
}