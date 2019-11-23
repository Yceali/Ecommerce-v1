using Ecommerce.Areas.Management.Models.Context;
using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repositories
{
    public class BrandRepository : Irepository<Brand>
    {

        private ApplicationDbContext db;

        public BrandRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Delete(Brand entitiy)
        {
            db.Brands.Remove(entitiy);
            db.SaveChanges();
        }

        public Brand Get(int Id)
        {
            return db.Brands.FirstOrDefault(x => x.Id == Id);
        }

        public List<Brand> GetAll()
        {
            return db.Brands.ToList();
        }

        public void Save(Brand entitiy)
        {
            db.Brands.Add(entitiy);
            db.SaveChanges();
        }

        public void Update(Brand entitiy)
        {
            db.Entry(entitiy).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}