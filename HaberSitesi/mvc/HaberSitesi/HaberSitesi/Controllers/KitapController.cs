using Microsoft.AspNetCore.Mvc;
using HaberSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            var kitaplar = KitapData.GetAllKitaplar();
            return View(kitaplar);
        }

        public IActionResult KitapDetay()
        {
            int ID = Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);
            var kitaplar = KitapData.GetAllKitaplar();
            Kitaplar secilenKitap = null;
            foreach(var kitap in kitaplar)
            {
                if (kitap.ID==ID)
                {
                    secilenKitap = kitap;
                    break;
                }
            }

            ViewBag.kitap = secilenKitap;
            return View();
        }





    }
}
