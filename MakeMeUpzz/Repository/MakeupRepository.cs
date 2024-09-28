using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupRepository
    {
        static MakeMeUpzzDBEntities db = new MakeMeUpzzDBEntities();
        public static List<Makeup> getAllMakeup()
        {
            return db.Makeups.ToList();
        }

        public static Makeup getMakeup(int id)
        {
            return (from p in db.Makeups
                    where p.MakeupID == id
                    select p).FirstOrDefault();
        }
        public static List<Makeup> getMakeupList(int id)
        {
            return (from p in db.Makeups
                    where p.MakeupID == id
                    select p).ToList();
        }
        public static void insertProduct(string makeupName, int makeupPrice, int makeupWeight, int makeupTypeId, int makeupBrandId)
        {
            Makeup newMakeup = MakeupsFactory.createMakeup(makeupName, makeupPrice, makeupWeight, makeupTypeId, makeupBrandId);
            db.Makeups.Add(newMakeup);
            db.SaveChanges();
        }
        public static void updateMakeup(int makeupId, string makeupName, int makeupPrice, int makeupWeight, int makeupTypeId, int makeupBrandId)
        {
            Makeup makeup = db.Makeups.Where(a => a.MakeupID == makeupId).FirstOrDefault();
            makeup.MakeupName = makeupName;
            makeup.MakeupPrice = makeupPrice;
            makeup.MakeupWeight = makeupWeight;
            makeup.MakeupTypeID = makeupTypeId;
            makeup.MakeupBrandID = makeupBrandId;
            db.SaveChanges();
        }
        public static void deleteMakeup(int makeupId)
        {
            Makeup makeup = db.Makeups.Where(a => a.MakeupID == makeupId).FirstOrDefault();
            db.Makeups.Remove(makeup);
            db.SaveChanges();
        }
    }
}