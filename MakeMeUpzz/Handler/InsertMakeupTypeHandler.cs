using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class InsertMakeupTypeHandler
    {
        public static void insertMakeupType(string typeName)
        {
            MakeupTypeRepository.InsertType(typeName);
        }
        public static MakeupType getMakeupTypebyName(string typeName)
        {
            return MakeupTypeRepository.getTypeByName(typeName);
        }
    }
}