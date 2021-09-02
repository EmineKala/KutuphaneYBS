using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneBS.Models.Entity;

namespace KutuphaneBS.Controllers
{
    public class IstekController : Controller
    {
        // GET: İstek
        Kutuphane_Bilgi_SistemiEntities db = new Kutuphane_Bilgi_SistemiEntities();
        public ActionResult Index()
        {
            var degerler = db.ISTEK.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult IstekEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IstekEkle(ISTEK i)
        {
            db.ISTEK.Add(i);
            db.SaveChanges();
            return View();
        }
        public ActionResult IstekSil(int Istek_ID)
        {
            var istek = db.CEZA.Find(Istek_ID);
            db.CEZA.Remove(istek);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
    }
