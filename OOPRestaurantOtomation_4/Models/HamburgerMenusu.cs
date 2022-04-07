using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRestaurantOtomation_4.Models
{
    public class HamburgerMenusu:BaseEntity
    {
        public HamburgerMenusu(decimal fiyat)
        {
            Fiyat = fiyat;
        }

        public string Aciklama { get; set; }

        public override string ToString()
        {
            return $"{Ad} => {Fiyat:C2}"; 
        }

       
    }
}
