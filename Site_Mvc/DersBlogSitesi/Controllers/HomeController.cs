using DersBlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSitesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var makaleler = new List<Makale>
            {
                new Makale
                {
                    ID=1,
                    Header="Makale ",
                    Content=" Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem soluta doloribus ab esse ut velit inventore. Provident unde quod mollitia illum nesciunt ullam totam cupiditate explicabo harum modi. Inventore dignissimos voluptate rem eaque recusandae cumque omnis velit nobis tempore ducimus, perferendis aut labore minusconsequatur quia delectus culpa? Facilis quis perferendis reprehenderit tempora enimnisi vero voluptate consequatur. In, eum."

                },
                new Makale
                {
                    ID=2,
                    Header="Makale ",
                    Content=" Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem soluta doloribus ab esse ut velit inventore. Provident unde quod mollitia illum nesciunt ullam totam cupiditate explicabo harum modi. Inventore dignissimos voluptate rem eaque recusandae cumque omnis velit nobis tempore ducimus, perferendis aut labore minusconsequatur quia delectus culpa? Facilis quis perferendis reprehenderit tempora enimnisi vero voluptate consequatur. In, eum."

                },
                new Makale
                {
                    ID=3,
                    Header="Makale ",
                    Content=" Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem soluta doloribus ab esse ut velit inventore. Provident unde quod mollitia illum nesciunt ullam totam cupiditate explicabo harum modi. Inventore dignissimos voluptate rem eaque recusandae cumque omnis velit nobis tempore ducimus, perferendis aut labore minusconsequatur quia delectus culpa? Facilis quis perferendis reprehenderit tempora enimnisi vero voluptate consequatur. In, eum."

                },
                new Makale
                {
                    ID=4,
                    Header="Makale ",
                    Content=" Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem soluta doloribus ab esse ut velit inventore. Provident unde quod mollitia illum nesciunt ullam totam cupiditate explicabo harum modi. Inventore dignissimos voluptate rem eaque recusandae cumque omnis velit nobis tempore ducimus, perferendis aut labore minusconsequatur quia delectus culpa? Facilis quis perferendis reprehenderit tempora enimnisi vero voluptate consequatur. In, eum."

                },
                 new Makale
                {
                    ID=5,
                    Header="Makale ",
                    Content=" Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem soluta doloribus ab esse ut velit inventore. Provident unde quod mollitia illum nesciunt ullam totam cupiditate explicabo harum modi. Inventore dignissimos voluptate rem eaque recusandae cumque omnis velit nobis tempore ducimus, perferendis aut labore minusconsequatur quia delectus culpa? Facilis quis perferendis reprehenderit tempora enimnisi vero voluptate consequatur. In, eum."

                },
                  new Makale
                {
                    ID=6,
                    Header="Makale ",
                    Content=" Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem soluta doloribus ab esse ut velit inventore. Provident unde quod mollitia illum nesciunt ullam totam cupiditate explicabo harum modi. Inventore dignissimos voluptate rem eaque recusandae cumque omnis velit nobis tempore ducimus, perferendis aut labore minusconsequatur quia delectus culpa? Facilis quis perferendis reprehenderit tempora enimnisi vero voluptate consequatur. In, eum."

                },
            };

            return View(makaleler);
        }
    }
}
