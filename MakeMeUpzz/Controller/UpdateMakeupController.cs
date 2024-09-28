using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class UpdateMakeupController
    {
        public static Boolean UpdateMakeup(int id, string name, int price, int weight, int typeId, int brandId)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                return false;
            }
            if (price < 1)
            {
                return false;
            }
            if (weight > 1500)
            {
                return false;
            }
            if (typeId <= 0 || brandId <= 0)
            {
                return false;
            }

            UpdateMakeupHandler.updateMakeup(id, name, price, weight, typeId, brandId);
            return true;
        }

        public static Makeup GetMakeupById(int id)
        {
            return UpdateMakeupHandler.GetMakeup(id);
        }
    }
}