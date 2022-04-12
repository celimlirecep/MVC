using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSitesi.Models
{
    public static class KitapData
    {
        public static List<Kitaplar> GetAllKitaplar()
        {
            var kitaplar = new List<Kitaplar>
            {
                new Kitaplar{ID= 15,KitapAdi="Araba Sevdası1"},
                new Kitaplar{ID= 16,KitapAdi="Araba Sevdası2"},
                new Kitaplar{ID= 17,KitapAdi="Araba Sevdası3"},
                new Kitaplar{ID= 18,KitapAdi="Araba Sevdası4"},
                new Kitaplar{ID= 19,KitapAdi="Araba Sevdası5"},
                new Kitaplar{ID= 20,KitapAdi="Araba Sevdası6"},


            };

            return kitaplar;
        }


    }
}
