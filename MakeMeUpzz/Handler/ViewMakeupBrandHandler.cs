using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class ViewMakeupBrandHandler
    {
        public static List<MakeupBrand> CheckMakeupBrand(int id)
        {
            return MakeupBrandRepository.getBrandByID(id);
        }

        public static string removeBrand(string brandName)
        {
            var brand = MakeupBrandRepository.getBrandyName(brandName);
            if (brand != null)
            {
                return "brand masih nyangkut di makeup bg";
            }
            MakeupBrandRepository.removeBrand(brandName);
            return $"{brandName} deleted";
        }
        public static List<MakeupBrand> getAllBrand()
        {
            return MakeupBrandRepository.getAllbrand();
        }
    }
}