using OOPRestaurantOtomation_4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRestaurantOtomation_4.Models
{
    public class Siparis : BaseEntity
    {

        public Siparis()
        {
            Malzemeleri = new List<EkstraMalzeme>();
        }
        public HamburgerMenusu SecilenMenu { get; set; }
        public short Adet { get; set; }
        public Boyut Buyukluk { get; set; }
        public List<EkstraMalzeme> Malzemeleri { get; set; }


        /// <summary>
        /// Bu metot siparişinizin tutarını hesaplamak icindir
        /// </summary>
        public void TutarHesapla()
        {
            Fiyat = SecilenMenu.Fiyat; //Siparişimiz bir HamburgerMenusu tipindeki property'si aracılıgı ile kullanıcı tarafından secilen menünün fiyatına ulasacak...Ve SecilenMenu'nun Fiyatı'nı Siparis'in Fiyat'ına atayaacgız...(Toplam tutar hesaplama durumunda ilk basta bunu yapıyoruz)

            switch (Buyukluk)
            {

                case Boyut.Orta:
                    Fiyat += 1;
                    break;
                case Boyut.Buyuk:
                    Fiyat += 2;
                    break;

            }

            foreach (EkstraMalzeme item in Malzemeleri)
            {
               
                Fiyat += item.Fiyat;
            }

            Fiyat *= Adet;


        }

      

        public override string ToString()
        {
            if(Malzemeleri.Count < 1)
            {
                //Eger kullanıcı malzeme secmemişsse bu malzemeler yazılmadan direkt menünün normal hali yazdırılsın...
                return $"{SecilenMenu.Ad} Menüsü, x {Adet},{Buyukluk} boy, Toplam: {Fiyat:C2} Kişi => {Ad}";
            }

            //Kullanıcının sectigi malzemelerin isimlerini de görmek istiyoruz...
            string malzemeleri = null;

            //Döngümüz burada koleksiyondaki malzemelerin isimlerini yakalayarak yukarıda actıgımız metinsel tipteki malzemeleri ismindeki degişkene atacak...

            foreach (EkstraMalzeme item in Malzemeleri)
            {
                //Döngü turlarında denk geldigimiz her elemanın tipi EkstraMalzeme'dir...
                malzemeleri += $"{item.Ad},";
            }

            //ketcap,mayonez,acısos,

            malzemeleri = malzemeleri.TrimEnd(','); //TrimEnd metodu bir string ifadenin sonundaki bir karakteri silmekle görevlidir...

            return $"{SecilenMenu.Ad} Menüsü, x {Adet}, {Buyukluk} boy, Malzemeleri: ({malzemeleri}), Toplam Tutar => {Fiyat:C2}.. Kişi => {Ad}";
        }


    }






}
