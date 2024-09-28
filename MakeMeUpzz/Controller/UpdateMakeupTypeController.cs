using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class UpdateMakeupTypeController
    {
        public static bool UpdateMakeupType(int id, string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                return false;
            }
            UpdateMakeupTypeHandler.updateMakeupType(id, name);
            return true;
        }
        public static List<MakeupType> getMakeupTypeUseId(int id)
        {
            return UpdateMakeupTypeHandler.getMakeupTypeUseId(id);
        }

        public static MakeupType getMakeupTypeUseName(string name)
        {
            return UpdateMakeupTypeHandler.getMakeupTypeUseName(name);
        }
    }
}