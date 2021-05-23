using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using yenisonproje.Models;

namespace yenisonproje.Controllers
{
    public class HomeController : Controller
    {
        Magaza_DBEntities db = new Magaza_DBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Urunler()
        {
            var urunler = db.Urun_Table.ToList();
            ViewBag.UrunSayisi = urunler.Where(i => i.U_Stok > 0).Count();
            return View(urunler);
        }
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(Kart_Table Model)
        {
            var kullanıcı = db.Kart_Table.FirstOrDefault(x => x.K_Id == Model.K_Id && x.K_Sifre == Model.K_Sifre);
            if(kullanıcı != null)
            {
                Session["K_Id"] = kullanıcı;
                return RedirectToAction("Profil", "Home");
                
            }
                return View();
        }
        public ActionResult Cikis()
        {

            Session["K_Id"] = null;
            return View();
        }
        public ActionResult Profil()
        {

            return View();
        }
    }
}