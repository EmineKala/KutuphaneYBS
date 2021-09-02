using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneBS.Models.Entity;

namespace KutuphaneBS.Controllers
{
    public class CezaController : Controller
    {
        // GET: Ceza
        Kutuphane_Bilgi_SistemiEntities db = new Kutuphane_Bilgi_SistemiEntities();
        public ActionResult Index()
        {
            var degerler = db.CEZA.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult CezaTipiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CezaTipiEkle(CEZA c)
        {
            db.CEZA.Add(c);
            //db.SaveChanges();
            return View();
        }
        public ActionResult CezaTipiSil(int Ceza_ID)
        {
            var cezatipi = db.CEZA.Find(Ceza_ID);
            db.CEZA.Remove(cezatipi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}