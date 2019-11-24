using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Areas.Management.Models.Entities
{
    public class Category:BaseEntity
    {
        [Display(Name = "Üst Kategori")]
        public int ParentId { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}