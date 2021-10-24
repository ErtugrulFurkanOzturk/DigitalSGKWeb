using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalSGKWeb.Models.EntityFramework
{
    public class MusterilerViewModel
    {
        public string MusteriKodu { get; set; }
       
        public string MusteriAdi { get; set; }
        public Nullable<short> Durumu { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<bool> isRutin { get; set; }
    }
}