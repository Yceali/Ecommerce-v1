using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Interface
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Crated => DateTime.Now;
    }
}