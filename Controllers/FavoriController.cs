using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneBS.Models.Entity;

namespace KutuphaneBS.Controllers
{
    
    public class FavoriController : Controller
    {
        // GET: Favori
        Kutuphane_Bilgi_SistemiEntities db = new Kutuphane_Bilgi_SistemiEntities();

        public ActionResult Index()
        {
            var degerler = db.FAVORI.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult FavoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FavoriEkle(FAVORI f)
        {
            db.FAVORI.Add(f);
            db.SaveChanges();
            return View();
        }
        public ActionResult FavoriSil(int Favori_ID)
        {
            var favori = db.FAVORI.Find(Favori_ID);
            db.FAVORI.Remove(favori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}