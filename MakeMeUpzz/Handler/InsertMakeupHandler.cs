using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class InsertMakeupHandler
    {
        public static void insertNewMakeup(string makeupName, int makeupPrice, int makeupWeight, int makeupTypeId, int makeupBrandId)
        {
            MakeupRepository.insertProduct(makeupName, makeupPrice, makeupWeight, makeupTypeId, makeupBrandId);
        }
        public static List<MakeupBrand> getMakeupBrandById(int brandId)
        {
            return MakeupBrandRepository.getBrandByID(brandId);
        }
        public static List<MakeupType> getMakeupTypeById(int typeId)
        {
            return MakeupTypeRepository.getTypeByID(typeId);
        }
        public static List<MakeupBrand> getAllMakeupBrand()
        {
            return MakeupBrandRepository.getAllbrand();
        }
        public static List<MakeupType> getAllMakeupType()
        {
            return MakeupTypeRepository.getAllType();
        }
        public static string getUserObj(object user)
        {
            return UserRepository.getUserObj(user);
        }
    }
}