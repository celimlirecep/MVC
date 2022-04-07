using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSitesi.Controllers
{
    public class MakaleIcerikController : Controller
    {

        [HttpGet]
        public ActionResult index()
        {
            return View();
        }
       
     

    }
}
