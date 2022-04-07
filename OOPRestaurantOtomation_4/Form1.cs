using OOPRestaurantOtomation_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPRestaurantOtomation_4
{
    public partial class Form1 : Form
    {

        //Tag property'si



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hamburger menülerini listemize object initializer yontemi ile ekliyoruz

            List<HamburgerMenusu> menuler = new List<HamburgerMenusu>
            {
                new HamburgerMenusu(15){Ad = "Texas SmokeHouhse",Aciklama = "Gurme menusunden enfes bir lezzet"},
                new HamburgerMenusu(18){Ad = "Barbekü Briouche",Aciklama = "Barbekülü bir Meksika ateşine hazır mısınız"},
                new HamburgerMenusu(20){Ad = "Crispy Chicken",Aciklama = "Tavuklar hic bu kadar cıtır olmamıstı"},
                new HamburgerMenusu(25){Ad = "SteakHouse",Aciklama = "Oyle bir tat alacaksınız ki bu para az diyeceksiniz"},
                new HamburgerMenusu(16){Ad = "TenderCrisp", Aciklama = "Hem acıyı aldık hem de cıtırı bir araya getirdik"}

            };



            //foreach (HamburgerMenusu item in menuler)
            //{
            //    cmbMenuler.Items.Add(item);
            //}

            cmbMenuler.DataSource = menuler;
            //cmbMenuler.SelectedIndex = -1;

        }

        private void cmbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAciklama.Text = (cmbMenuler.SelectedItem as HamburgerMenusu).Aciklama;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region SiparisYaratmaIslemi

            Siparis s = new Siparis();
            s.SecilenMenu = cmbMenuler.SelectedItem as HamburgerMenusu;
            s.Adet = Convert.ToInt16(nmrAdet.Value);

            if (rdbBuyuk.Checked) s.Buyukluk = Enums.Boyut.Buyuk;
            else if (rdbOrta.Checked) s.Buyukluk = Enums.Boyut.Orta;
            else s.Buyukluk = Enums.Boyut.Kucuk;

            //Kişinin malzeme secip secmedigini kontrol edecegiz...

            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    EkstraMalzeme eks = new EkstraMalzeme(Convert.ToDecimal(item.Tag)); //Ekstraalzeme sınıfının instance'ini alırken constructor'ina ilgili item'in Tag property'sindeki degeri vererek instance'imizin fiyatını atamıs olduk...

                    eks.Ad = item.Text;
                    //Fiyatı CheckBox kontrolünün tag property'sinden aldık...Tag property'si , kontrolün icerisinde istedigimiz tipte(object tipinde deger aldıgı icin) deger tutmamızı saglar...O kontrolün deger tasıyabilecegini ozel bir alanı olarak düsünebilirsiniz...Ancak object tipte deger aldıgı icin unboxing gerekir...

                    s.Malzemeleri.Add(eks);
                }

            }

            s.Ad = txtIsim.Text; //Siparişimizin ismini atıyoruz
            s.TutarHesapla(); //Siparişimizin toplam tutarının hesaplanması adına bu metodun cagrılması lazım
            lstSiparisler.Items.Add(s); //en son her seyi hazırlanmıs olan siparişimizi ListBox'a ekliyoruz...



            #endregion


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Hesapla butonuna bastıgınızda ListBox'a eklenmiş olan bütün siparişlerin toplam tutarı o anki ciro olarak MessageBox'ta gösterilsin...

            decimal toplamTutar = 0;

            foreach (Siparis item in lstSiparisler.Items)
            {
                toplamTutar += item.Fiyat;
            }


            MessageBox.Show(toplamTutar.ToString());
        }
    }
}
