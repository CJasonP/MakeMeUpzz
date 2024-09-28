using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class UpdateMakeupHandler
    {
        public static void updateMakeup(int id, string name, int price, int weight, int typeId, int brandId)
        {
            MakeupRepository.updateMakeup(id, name, price, weight, typeId, brandId);
        }
        public static Makeup GetMakeup(int id)
        {
            return MakeupRepository.getMakeup(id);
        }
    }
}