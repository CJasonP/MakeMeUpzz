using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MakeMeUpzz.Controller
{
    public class InsertMakeupController
    {
        public static string InsertNewMakeup(string makeupName, int makeupPrice, int makeupWeight, int makeupTypeId, int makeupBrandId)
        {
            if (string.IsNullOrEmpty(makeupName) || makeupName.Length < 1 || makeupName.Length > 99)
            {
                return "Name must be filled";
            }
            else if (makeupPrice < 1)
            {
                return "Price must be above 1";
            }
            else if (makeupWeight > 1500)
            {
                return "Weight must be under 1500";
            }
            else if (makeupTypeId <= 0 || makeupBrandId <= 0)
            {
                return "Id must be filled";
            }
            else
            {
                var productType = InsertMakeupHandler.getMakeupTypeById(makeupTypeId);
                var brandType = InsertMakeupHandler.getMakeupBrandById(makeupBrandId);
                if (productType == null && brandType == null)
                {
                    return "No Product Type or Brand Type in database";
                }
                else
                {
                    InsertMakeupHandler.insertNewMakeup(makeupName, makeupPrice, makeupWeight, makeupTypeId, makeupBrandId);
                    return "Makeup inserted into database";
                }
            }
        }
        public static bool getUserObj(object user)
        {
            if (InsertMakeupHandler.getUserObj(user) == "Customer") return true;
            return false;
        }
        public static List<MakeupBrand> GetAllMakeupBrand()
        {
            return InsertMakeupHandler.getAllMakeupBrand();
        }

        public static List<MakeupType> GetAllMakeupType()
        {
            return InsertMakeupHandler.getAllMakeupType();
        }
    }
}