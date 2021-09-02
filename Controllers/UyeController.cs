using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneBS.Models.Entity;

namespace KutuphaneBS.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        Kutuphane_Bilgi_SistemiEntities db = new Kutuphane_Bilgi_SistemiEntities();
        public ActionResult Index()
        {
            var degerler = db.UYE.ToList();
            return View(degerler);
        }
        public ActionResult UyeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeEkle(UYE u)
        {
            db.UYE.Add(u);
            db.SaveChanges();
            return View();
        }
        public ActionResult UyeSil(int Uye_ID)
        {
            var uye = db.UYE.Find(Uye_ID);
            db.UYE.Remove(uye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}