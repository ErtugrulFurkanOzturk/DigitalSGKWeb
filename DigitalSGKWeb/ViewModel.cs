using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DigitalSGKWeb.Models.EntityFramework;

namespace DigitalSGKWeb
{
    public class ViewModel
    {
        public List<Musteriler> MusterilerList { get; set; }
        public List<ABPYRSubeler> SubelerList { get; set; }
        public Musteriler Musteriler { get; set; }
        public ABPYRSubeler Subeler { get; set; }
    }
}