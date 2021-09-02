using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneBS.Models.Entity;

namespace KutuphaneBS.Controllers
{
    public class YorumController : Controller
    {
        // GET: Yorum
        Kutuphane_Bilgi_SistemiEntities db = new Kutuphane_Bilgi_SistemiEntities();
        public ActionResult Index()
        {
            var degerler = db.YORUM.ToList();
            return View(degerler); ;
        }
        [HttpGet]
        public ActionResult YorumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YorumEkle(YORUM y)
        {
            db.YORUM.Add(y);
            db.SaveChanges();
            return View();
        }
        public ActionResult YorumSil(int Yorum_ID)
        {
            var yorum = db.YORUM.Find(Yorum_ID);
            db.YORUM.Remove(yorum);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumGuncelle(int Yorum_ID)
        {
            var yorum = db.YORUM.Find(Yorum_ID);
            db.YORUM.Remove(yorum);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}