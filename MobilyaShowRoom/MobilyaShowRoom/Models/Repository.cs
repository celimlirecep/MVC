using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Models
{
    public static class Repository
    {
        public static List<Product> AllProducts()
        {
            var products = new List<Product>
            {
                new Product {ID =540,ProductName="Sürgülü Kapılı Dolap 1",ProductDetail="Sürgülü Kapılı dolap aynalı model",Price=4700 },
                new Product {ID =545,ProductName="Sürgülü Kapılı Dolap 2",ProductDetail="Sürgülü Kapılı dolap aynalı model",Price=5700 },
                new Product {ID =550,ProductName="Sürgülü Kapılı Dolap 3",ProductDetail="Sürgülü Kapılı dolap aynalı model",Price=6700 },
                new Product {ID =555,ProductName="Sürgülü Kapılı Dolap 4",ProductDetail="Sürgülü Kapılı dolap aynalı model",Price=7700 },
                new Product {ID =560,ProductName="Sürgülü Kapılı Dolap 5",ProductDetail="Sürgülü Kapılı dolap aynalı model",Price=8700 },
                new Product {ID =565,ProductName="Sürgülü Kapılı Dolap 6",ProductDetail="Sürgülü Kapılı dolap aynalı model",Price=9700 },
            };
            return products;
        }
    }
}
