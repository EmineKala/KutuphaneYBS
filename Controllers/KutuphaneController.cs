using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneBS.Models.Entity;

namespace KutuphaneBS.Controllers
{
    public class KutuphaneController : Controller
    {
        // GET: Kutuphane
        Kutuphane_Bilgi_SistemiEntities db = new Kutuphane_Bilgi_SistemiEntities();
        public ActionResult Index()
        {
            var degerler = db.KUTUPHANE.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KutuphaneEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KutuphaneEkle(KUTUPHANE kutup)
        {
            db.KUTUPHANE.Add(kutup);
            db.SaveChanges();
            return View();
        }
        public ActionResult KutuphaneSil(int Kutuphane_ID)
        {
            var kutuphane = db.KUTUPHANE.Find(Kutuphane_ID);
            db.KUTUPHANE.Remove(kutuphane);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}