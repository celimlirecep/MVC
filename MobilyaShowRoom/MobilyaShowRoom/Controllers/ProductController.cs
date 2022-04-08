using Microsoft.AspNetCore.Mvc;
using MobilyaShowRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Controllers
{
    public class ProductController : Controller
    {
      
        public IActionResult Index()
        {
            var products = Repository.AllProducts();
            return View(products);
        }
        
        public IActionResult GetProductDetail()
        {
            int id =Convert.ToInt32( ControllerContext.RouteData.Values["ID"]);
            //Models içerisindeki verilerden şu id li olanı getirin
            var products = Repository.AllProducts();
            Product resultProduct = null;
            foreach(var ürün in products)
            {
                if (ürün.ID==id)
                {

                    resultProduct = ürün;
                    break;
                }
            }
            ViewBag.Product = resultProduct;

            return View();

        } 
    }
}
