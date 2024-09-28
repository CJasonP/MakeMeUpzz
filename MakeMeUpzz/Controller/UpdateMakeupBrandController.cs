using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class UpdateMakeupBrandController
    {
        public static bool UpdateMakeupBrand(int id, string name, int rating)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                return false;
            }
            if (rating > 100 || rating < 1)
            {
                return false;
            }
            UpdateMakeupBrandHandler.updateMakeupBrand(id, name, rating);
            return true;
        }
        public static List<MakeupBrand> getMakeupBrandUseId(int id)
        {
            return UpdateMakeupBrandHandler.getMakeupBrandUseId(id);
        }

        public static MakeupBrand getMakeupBrandUseName(string name)
        {
            return UpdateMakeupBrandHandler.getMakeupBrandUseName(name);
        }
    }
}