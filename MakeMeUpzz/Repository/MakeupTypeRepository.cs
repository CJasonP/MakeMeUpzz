using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupTypeRepository
    {
        static MakeMeUpzzDBEntities db = new MakeMeUpzzDBEntities();
        public static List<MakeupType> getAllType()
        {
            return db.MakeupTypes.ToList();
        }
        public static void InsertType(string name)
        {
            MakeupType newType = MakeupsTypeFactory.insertMakeupType(name);
            db.MakeupTypes.Add(newType);
            db.SaveChanges();
        }
        public static void removeType(string name)
        {
            MakeupType type = db.MakeupTypes.Where(a => a.MakeupTypeName == name).FirstOrDefault();
            db.MakeupTypes.Remove(type);
            db.SaveChanges();
        }
        public static void updateType(int typeID, string typeName)
        {
            MakeupType type = db.MakeupTypes.Where(a => a.MakeupTypeID == typeID).FirstOrDefault();
            type.MakeupTypeName = typeName;
            db.SaveChanges();
        }
        public static List<MakeupType> getTypeByID(int productTypeID)
        {
            return db.MakeupTypes.Where(a => a.MakeupTypeID == productTypeID).ToList();
        }

        public static MakeupType getTypeByName(string typeName)
        {
            return db.MakeupTypes.Where(a => a.MakeupTypeName == typeName).FirstOrDefault();
        }
    }
}