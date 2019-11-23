using Ecommerce.Areas.Management.Models.Context;
using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repositories
{
    public class CategoryRepository : Irepository<Category>
    {
        private ApplicationDbContext db;

        public CategoryRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Delete(Category entitiy)
        {
            db.Categories.Remove(entitiy);
            db.SaveChanges();
        }

        public Category Get(int Id)
        {
           return db.Categories.FirstOrDefault(x=>x.Id == Id);
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public void Save(Category entitiy)
        {
            db.Categories.Add(entitiy);
            db.SaveChanges();
        }

        public void Update(Category entitiy)
        {
            db.Entry(entitiy).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}