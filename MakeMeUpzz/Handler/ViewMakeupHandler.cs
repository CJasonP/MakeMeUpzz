using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class ViewMakeupHandler
    {
        public static List<Makeup> getAllMakeup()
        {
            return MakeupRepository.getAllMakeup();
        }
        public static void deleteMakeup(int id)
        {
            MakeupRepository.deleteMakeup(id);
        }
    }
}