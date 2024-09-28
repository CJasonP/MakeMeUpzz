using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupsFactory
    {
        public static Makeup createMakeup(string makeupName, int makeupPrice, int makeupWeight, int makeupTypeId, int makeupBrandId)
        {
            Makeup makeup= new Makeup();
            makeup.MakeupName = makeupName;
            makeup.MakeupPrice = makeupPrice;
            makeup.MakeupWeight = makeupWeight;
            makeup.MakeupTypeID = makeupTypeId;
            makeup.MakeupBrandID = makeupBrandId;
            return makeup;
        }
    }
}