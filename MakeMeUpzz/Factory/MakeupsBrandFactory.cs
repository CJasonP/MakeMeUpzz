using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupsBrandFactory
    {
        public static MakeupBrand insertMakeupBrand(string makeupBrandName, int makeupBrandRating)
        {
            MakeupBrand brand = new MakeupBrand();
            //brand.MakeupBrandID = makeupBrandId;
            brand.MakeupBrandName = makeupBrandName;
            brand.MakeupBrandRating = makeupBrandRating;
            return brand;
        } 
    }
}