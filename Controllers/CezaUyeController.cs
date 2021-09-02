using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneBS.Models.Entity;

namespace KutuphaneBS.Controllers
{
    public class CezaUyeController : Controller
    {
        // GET: CezaUye
        Kutuphane_Bilgi_SistemiEntities db = new Kutuphane_Bilgi_SistemiEntities();
        public ActionResult Index()
        {
            var degerler = db.CEZA_UYE.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult CezaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CezaEkle(CEZA_UYE cu)
        {
            db.CEZA_UYE.Add(cu);
            db.SaveChanges();
            return View();
        }
        public ActionResult CezaSil(int Uye_ID)
        {
            var ceza = db.CEZA.Find(Uye_ID);
            db.CEZA.Remove(ceza);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}