using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Models
{
    public static class KisilerRepo
    {
        public static List<Kisiler> AllKisiler()
        {
            var kisiler = new List<Kisiler>
            {
                new Kisiler{ID=15,Ad="recep",Meslek="Mühendis"},
                new Kisiler{ID=16,Ad="recep",Meslek="Mühendis"},
                new Kisiler{ID=17,Ad="recep",Meslek="Mühendis"},
                new Kisiler{ID=18,Ad="recep",Meslek="Mühendis"},
            };

            return kisiler;
        }
    }
}
