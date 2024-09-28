using MakeMeUpzz.Handler;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class InsertMakeupBrandController
    {
        public static string insertMakeupBrand(string brandName, int rating)
        {
            if (string.IsNullOrEmpty(brandName) || brandName.Length < 1 || brandName.Length > 99)
            {
                return "Name must be filled";
            }
            if (rating < 0 || rating > 100)
            {
                return "Rating must be betewen 0 - 100";
            }
            InsertMakeupBrandHandler.insertMakeupBrand(brandName, rating);
            return "Makeup Brand successfully added to Database";
        }

        public static MakeupBrand GetMakeupBrandByName(string brandName)
        {
            return InsertMakeupBrandHandler.GetMakeupBrandByName(brandName);
        }
    }
}