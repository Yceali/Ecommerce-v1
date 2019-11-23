﻿using Ecommerce.Areas.Management.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(): base("name=MyECommerce")
        {

        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
    }
}