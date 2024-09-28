using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MakeMeUpzz.Repository
{
    public class MakeupBrandRepository
    {
        static MakeMeUpzzDBEntities db = new MakeMeUpzzDBEntities();
        public static List<MakeupBrand> getAllbrand()
        {
            return db.MakeupBrands.ToList();
        }
        public static void InsertBrand(string name, int rating)
        {
            MakeupBrand newBrand = MakeupsBrandFactory.insertMakeupBrand(name, rating);
            db.MakeupBrands.Add(newBrand);
            db.SaveChanges();
        }
        public static void removeBrand(string name)
        {
            MakeupBrand brand = db.MakeupBrands.Where(a => a.MakeupBrandName == name).FirstOrDefault();
            db.MakeupBrands.Remove(brand);
            db.SaveChanges();
        }
        public static void updateBrand(int brandId, string brandName, int rating)
        {
            MakeupBrand brand = db.MakeupBrands.Where(a => a.MakeupBrandID == brandId).FirstOrDefault();
            brand.MakeupBrandName = brandName;
            brand.MakeupBrandRating = rating;
            db.SaveChanges();
        }
        public static List<MakeupBrand> getBrandByID(int brandId)
        {
            return db.MakeupBrands.Where(a => a.MakeupBrandID == brandId).ToList();
        }

        public static MakeupBrand getBrandyName(string brandName)
        {
            return db.MakeupBrands.Where(a => a.MakeupBrandName == brandName).FirstOrDefault();
        }
    }
}