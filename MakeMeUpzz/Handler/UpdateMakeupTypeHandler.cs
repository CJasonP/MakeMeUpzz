using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class UpdateMakeupTypeHandler
    {
        public static List<MakeupType> getMakeupTypeUseId(int id)
        {
            return MakeupTypeRepository.getTypeByID(id);
        }

        public static MakeupType getMakeupTypeUseName(string name)
        {
            return MakeupTypeRepository.getTypeByName(name);
        }
        public static void updateMakeupType(int id, string name)
        {
            MakeupTypeRepository.updateType(id, name);
        }
    }
}