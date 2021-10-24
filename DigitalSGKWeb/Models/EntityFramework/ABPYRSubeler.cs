//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalSGKWeb.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ABPYRSubeler
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "�ube Kodu Bo� B�rak�lamaz!!!")]
        [StringLength(50, ErrorMessage = "En Fazla 200 Karakterlik �sim Girilebilir!!!")]
        public string SubeKodu { get; set; }
        [Required(ErrorMessage = "�ube Ad� Bo� B�rak�lamaz!!!")]
        [StringLength(200, ErrorMessage = "En Fazla 200 Karakterlik �sim Girilebilir!!!")]
        public string SubeAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public string IsyeriKodu { get; set; }
        public string SistemSifresi { get; set; }
        public string IsyeriSifresi { get; set; }
        public Nullable<bool> Visible { get; set; }
        public string Musteri { get; set; }
        public string Bayi { get; set; }
        public Nullable<bool> Tamamlandi { get; set; }
        public string Sebep { get; set; }
        public string SicilNo { get; set; }
        public string Unvan { get; set; }
        public string VKN { get; set; }
        public string VergiDairesi { get; set; }
        public string Adres { get; set; }
        public string DisKapi { get; set; }
        public string IcKapi { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public string SGMKod { get; set; }
        public string SGMAd { get; set; }
        public Nullable<float> EskiOran { get; set; }
    
        public virtual Musteriler Musteriler { get; set; }
    }
}
