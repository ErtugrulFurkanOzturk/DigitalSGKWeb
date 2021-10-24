using DigitalSGKWeb.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace DigitalSGKWeb.Controllers
{
    public class MusterilerController : Controller
    {
        DEntities db = new DEntities();
        // GET: Musteriler
        //public ActionResult Index()
        //{
        //    var degerler = db.Musteriler.ToList();
        //    return View(degerler);
        //}

        public ActionResult Index(string adara)
        {
           
            return View(db.Musteriler.Where(x=>x.MusteriAdi.Contains(adara)||adara==null).ToList());
        }


        public ActionResult MusteriSubesi(string id)
        {
            var model = db.ABPYRSubeler.Where(x=>x.Musteri==id).ToList();

            return View(model);
        }


        [HttpGet]
        public ActionResult MusteriEkleme()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MusteriEkleme(Musteriler musteri)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("MusteriEklemePartial");
            }

            db.Musteriler.Add(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(string id)
        {
            var deger = db.Musteriler.Find(id);
            
            return PartialView("Index", deger);
        }
        
        public ActionResult MusteriGetirPartial(string id)
        {
            var deger = db.Musteriler.Find(id);

            return PartialView("MusteriGetirPartial", deger);
        }
        //public ActionResult MusteriGuncelle(Musteriler musteriler)
        //{
        //    var degerler = db.Musteriler.Find(musteriler.MusteriKodu);
        //    degerler.MusteriAdi = musteriler.MusteriAdi;
        //    degerler.createdDate = musteriler.createdDate;
        //    degerler.Durumu = musteriler.Durumu;
        //    db.SaveChanges();
        //    ViewBag.dgr = degerler;
        //    return RedirectToAction("Index");
        //}
        public PartialViewResult MusteriGuncellemePartial()
        {
            return PartialView();
        }
        public PartialViewResult MusteriEklemePartial()
        {
            return PartialView();
        }

        public JsonResult GetMusterilerList()
        {
            List<MusterilerViewModel> MusList = db.Musteriler.Where(x => x.isRutin == false).Select(x => new MusterilerViewModel
            {
                MusteriKodu = x.MusteriKodu,
                MusteriAdi = x.MusteriAdi,
                Durumu = x.Durumu,
                createdDate = x.createdDate
            }).ToList();
            return Json(MusList, JsonRequestBehavior.AllowGet);
        }
    }
}