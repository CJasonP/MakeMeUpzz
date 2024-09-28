using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class InsertMakeupBrandHandler
    {
        public static void insertMakeupBrand(string brandName, int rating)
        {
            MakeupBrandRepository.InsertBrand(brandName, rating);
        }
        public static MakeupBrand GetMakeupBrandByName(string brandName)
        {
            return MakeupBrandRepository.getBrandyName(brandName);
        }
    }
}