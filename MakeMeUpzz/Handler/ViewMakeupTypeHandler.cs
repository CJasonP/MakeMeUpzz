using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class ViewMakeupTypeHandler
    {
        public static List<MakeupType> CheckMakeupType(int id)
        {
            return MakeupTypeRepository.getTypeByID(id);
        }

        public static string removeType(string typeName)
        {
            var type = MakeupTypeRepository.getTypeByName(typeName);
            if (type != null)
            {
                return "type masih nyangkut di makeup bg";
            }
            MakeupTypeRepository.removeType(typeName);
            return $"{typeName} deleted";
        }
        public static List<MakeupType> getAllType()
        {
            return MakeupTypeRepository.getAllType();
        }
    }
}