using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Areas.Management.Models.Interface
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Araç Adı")]
        [Required(ErrorMessage = "Seçim Yapınız")]
        public string Name { get; set; }

        [Display(Name = "Araç oluşturma Tarihi")]
        public DateTime Crated => DateTime.Now;
    }
}