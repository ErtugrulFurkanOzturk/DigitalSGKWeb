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

    public partial class Musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteriler()
        {
            this.ABPYRSubeler = new HashSet<ABPYRSubeler>();
        }

        public long Id { get; set; }
        [Required(ErrorMessage = "M��teri Kodu Bo� B�rak�lamaz!!!")]
        [StringLength(200,ErrorMessage ="En Fazla 200 Karakterlik �sim Girilebilir!!!")]
        public string MusteriKodu { get; set; }
        [Required(ErrorMessage = "M��teri Ad� Bo� B�rak�lamaz!!!")]
        [StringLength(200, ErrorMessage = "En Fazla 200 Karakterlik �sim Girilebilir!!!")]
        public string MusteriAdi { get; set; }
        public string BayiKodu { get; set; }
        public string BayiMusteriKodu { get; set; }
        public Nullable<short> Durumu { get; set; }
        public Nullable<bool> Faturalandi { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<int> BayiCounter { get; set; }
        public Nullable<float> AltiAylikTutar { get; set; }
        public string ilgiliKisi { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public Nullable<bool> isRutin { get; set; }
        public Nullable<short> RutinDurumu { get; set; }
        public string Tip { get; set; }
        public Nullable<float> Tutar { get; set; }
        public Nullable<float> Bayi1Oran { get; set; }
        public Nullable<float> Bayi2Oran { get; set; }
        public string VD { get; set; }
        public string VKN { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public Nullable<float> TeklifFiyati { get; set; }
        public Nullable<float> SatisFiyati { get; set; }
        public string Aciklama { get; set; }
        public Nullable<short> LostReason { get; set; }
        public Nullable<short> Statu { get; set; }
        public Nullable<System.DateTime> SatisTarihi { get; set; }
        public string Adres { get; set; }
        public string Unvan { get; set; }
        public Nullable<short> SatisDurumu { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string CRM_Ciro { get; set; }
        public string CRM_PMA { get; set; }
        public string CRM_Stratejik { get; set; }
        public Nullable<bool> EVizite { get; set; }
        public Nullable<bool> isGecmisDonemRutin { get; set; }
        public string SMMM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ABPYRSubeler> ABPYRSubeler { get; set; }
    }
}
