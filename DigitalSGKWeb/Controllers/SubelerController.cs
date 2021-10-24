using DigitalSGKWeb.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace DigitalSGKWeb.Controllers
{
    public class SubelerController : Controller
    {
        DEntities db = new DEntities();

        public ActionResult Index()
        {
            var degerler = db.ABPYRSubeler.ToList();
            return View(degerler);

        }


        [HttpGet]
        public ActionResult SubeEkle()
        {
            List<SelectListItem> degerler = (from i in db.Musteriler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.MusteriAdi,
                                                 Value = i.MusteriKodu.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
       [HttpPost]
        public ActionResult SubeEkle(ABPYRSubeler subeler)
        {
            var sube = db.Musteriler.Where(m => m.MusteriKodu == subeler.Musteriler.MusteriKodu).FirstOrDefault();
            subeler.Musteriler = sube;
            db.ABPYRSubeler.Add(subeler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SubeGetir(int id)
        {
            var sube = db.ABPYRSubeler.Find(id);
            return View("SubeGetir",sube);
        }

        public ActionResult SubeGuncelle(ABPYRSubeler subeler)
        {
            var degerler = db.ABPYRSubeler.Find(subeler.Id);
            degerler.SubeAdi = subeler.SubeAdi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult SubeEklemePartial()
        {
            List<SelectListItem> degerler = (from i in db.Musteriler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.MusteriAdi,
                                                 Value = i.MusteriKodu.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return PartialView();
        }
        public PartialViewResult SubeGuncellemePartial()
        {
            return PartialView();
        }
    }
}