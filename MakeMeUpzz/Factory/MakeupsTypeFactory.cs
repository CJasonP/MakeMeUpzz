using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupsTypeFactory
    {
        public static MakeupType insertMakeupType(string makeupTypeName)
        {
            MakeupType type = new MakeupType();
           // type.MakeupTypeID = makeupTypeId;
            type.MakeupTypeName = makeupTypeName;
            return type;
        }
    }
}