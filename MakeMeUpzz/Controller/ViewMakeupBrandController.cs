using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class ViewMakeupBrandController
    {
        public static List<MakeupBrand> getAllMakeupBrand()
        {
            return ViewMakeupBrandHandler.getAllBrand();
        }
        public static string removeBrand(String name)
        {
            return ViewMakeupBrandHandler.removeBrand(name);
        }
        public static List<MakeupBrand> CheckMakeupBrand(int id)
        {
            return ViewMakeupBrandHandler.CheckMakeupBrand(id);
        }
    }
}