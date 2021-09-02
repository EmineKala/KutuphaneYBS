using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneBS.Models.Entity;

namespace KutuphaneBS.Controllers
{
    public class KitapController : Controller
    {
        // GET: Kitap
        Kutuphane_Bilgi_SistemiEntities db = new Kutuphane_Bilgi_SistemiEntities();
        public ActionResult Index(string p)
        {
           
           var degerler = db.KITAP.ToList();
            return View(degerler.ToList());
        }
        [HttpGet]
        public ActionResult KitapEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KitapEkle(KITAP k)
        {
            db.KITAP.Add(k);
            db.SaveChanges();
            return View();
        }
        public ActionResult KitapSil(int Kitap_ID)
        {
            var kitap = db.KITAP.Find(Kitap_ID);
            db.KITAP.Remove(kitap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}