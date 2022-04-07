using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRestaurantOtomation_4.Models
{
    public class EkstraMalzeme:BaseEntity
    {
        public EkstraMalzeme(decimal fiyat)
        {
            Fiyat = fiyat;
        }
    }
}
