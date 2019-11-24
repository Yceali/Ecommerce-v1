using Ecommerce.Areas.Management.Models.Context;
using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repositories
{
    public class ProductRepository : Irepository<Product>
    {
        private ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public void Delete(Product entitiy)
        {
            db.Products.Remove(entitiy);
            db.SaveChanges();
        }

        public Product Get(int Id)
        {
            return db.Products.FirstOrDefault(x => x.Id == Id);
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public void Save(Product entitiy)
        {
            db.Products.Add(entitiy);
            db.SaveChanges();
        }

        public void Update(Product entitiy)
        {
            db.Entry(entitiy).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}