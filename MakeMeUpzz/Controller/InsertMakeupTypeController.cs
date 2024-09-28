using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class InsertMakeupTypeController
    {
        public static string InsertMakeupType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName) || typeName.Length < 1 || typeName.Length > 99)
            {
                return "Name must be filled";
            }
            InsertMakeupTypeHandler.insertMakeupType(typeName);
            return "Makeup Type has been added to the Database";
        }

        public static MakeupType GetMakeupTypeByName(string typeName)
        {
            return InsertMakeupTypeHandler.getMakeupTypebyName(typeName);
        }
    }
}