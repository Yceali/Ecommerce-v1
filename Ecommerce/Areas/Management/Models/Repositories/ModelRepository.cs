using Ecommerce.Areas.Management.Models.Context;
using Ecommerce.Areas.Management.Models.Entities;
using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Repositories
{
    public class ModelRepository : Irepository<Model>
    {
        ApplicationDbContext db;
        public ModelRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Delete(Model entitiy)
        {
            db.Models.Remove(entitiy);
            db.SaveChanges();
        }

        public Model Get(int Id)
        {
            return db.Models.FirstOrDefault(x => x.Id == Id);
        }

        public List<Model> GetAll()
        {
            return db.Models.ToList();
        }

        public void Save(Model entitiy)
        {
            db.Models.Add(entitiy);
            db.SaveChanges();
        }

        public void Update(Model entitiy)
        {
            db.Entry(entitiy).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}