using Ecommerce.Areas.Management.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Display ve requred elementleri için kullanılan kütüphane

namespace Ecommerce.Areas.Management.Models.Entities
{
    public enum autoClass
    {
        Ekonomi,
        Ortasınıf,
        LüxSınıf
    }
    public enum autoGear
    {
        Manuel,
        Otomatik
    }
    public enum autoFuel
    {
        Benzin,
        Dizel,
        Elektrik,
        Hibrit
    }
    public class Product : BaseEntity
    {
        [Display(Name ="Araç Sınıfı")]
        [Required(ErrorMessage = "Seçim Yapınız")]
        public autoClass autoClass { get; set; }

        [Display(Name = "Yakıt Tipi")]
        [Required(ErrorMessage ="Seçim Yapınız")]
        public autoFuel autoFuel { get; set; }

        [Display(Name = "Vites Tipi")]
        [Required(ErrorMessage = "Seçim Yapınız")]
        public autoGear autoGear { get; set; }

        public int brandID { get; set; }
        public int productID { get; set; }
        public Brand productBrand { get; set; }
        public Category productCategory { get; set; }

        [Display(Name = "Araç Yılı")]
        [Required(ErrorMessage = "Seçim Yapınız")]
        public int autoModelYear { get; set; }

        [Display(Name = "Araç KM")]
        [Required(ErrorMessage = "Seçim Yapınız")]
        public int kilometer { get; set; }

        [Display(Name = "Tutar")]
        [Required(ErrorMessage = "Seçim Yapınız")]
        public decimal dailyPrice { get; set; }

        [Display(Name = "İndirim")]
        public decimal discount { get; set; }


        [Display(Name = "Araç Resmi")]
        public byte[] image { get; set; }
    }
}