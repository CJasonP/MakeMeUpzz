using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class UpdateMakeupBrandHandler
    {
        public static List<MakeupBrand> getMakeupBrandUseId(int id)
        {
            return MakeupBrandRepository.getBrandByID(id);
        }

        public static MakeupBrand getMakeupBrandUseName(string name)
        {
            return MakeupBrandRepository.getBrandyName(name);
        }
        public static void updateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrandRepository.updateBrand(id, name, rating);
        }
    }
}