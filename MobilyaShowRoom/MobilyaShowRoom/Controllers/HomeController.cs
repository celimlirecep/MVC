using Microsoft.AspNetCore.Mvc;
using MobilyaShowRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
