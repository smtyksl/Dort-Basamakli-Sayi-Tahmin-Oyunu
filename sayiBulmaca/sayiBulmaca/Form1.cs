using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayiBulmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BilgisayarRastgeleSayiUret();//kullanının aklında tuttugu sayının ilk olarak tahmini 
            txtBilgisayarTahmini.Text = BilgisayarınUrettigiSayi.sayi.ToString();
            EskiBasamakElemanlari.Clear();
            Karaliste.Clear();
            BeyazListe.Clear();
            KesinListe.Clear();
            btnKullaniciTahmin.Enabled = false;
            btnBilgisayaraTahminYaptir.Enabled = false;
            txtBilgisayarTahmini.Enabled = false;
            btnBilgisayarınTahminEttigiSayiyiSifirla.Enabled = false;
        }

        #region değişken ve liste tanımlar

        int Suaneslesmebasamak, Suaneslesmesayi;
        int counter = 0;
        int basamak = 0;
        int degisenSayi;
        int sayac = 0;
        int uretilenSayi = 0;

        List<int> Karaliste = new List<int>();
        List<int> BeyazListe = new List<int>();
        List<int> KesinListe = new List<int>();
        List<int> EskiBasamakElemanlari = new List<int>();
        List<Sayi> BilgisayarTahminleriListesi = new List<Sayi>();

        #endregion

        #region sayı classı

        public class Sayi
        {
            public int sayi;
            public int EslesenBasamakMiktari = 0;
            public int EslesenSayiMiktari = 0;
            public int[] dizi = new int[4];
        }

        #endregion

        #region kullanıcının tahmin etmesi
        Sayi BilgisayarınTuttuguSayi = new Sayi();
        Sayi KullaniciTahmini = new Sayi();
        int Gecici;

        /// <summary>
        /// kullanıcının tahmin ettiği sayının basamaklarına ayrılması işlemi
        /// </summary>
        public void KullaniciTahmin()
        {
            Gecici = KullaniciTahmini.sayi = Convert.ToInt32(txtKullaniciTahmini.Text);
            for (int i = 0; i < 4; i++)
            {
                KullaniciTahmini.dizi[i] = Gecici % 10;
                Gecici /= 10;
            }
            EslesmeBul();

        }

        /// <summary>
        /// // eşleşen bassamak ya da sayı miktarını bulur
        /// </summary>
        public void EslesmeBul()
        {

            for (int i = 0; i < 4; i++)
            {
                if (KullaniciTahmini.dizi[i] == BilgisayarınTuttuguSayi.dizi[i]) // eşleşen basamak miktarı kontrolü
                {
                    KullaniciTahmini.EslesenBasamakMiktari++;
                }
                for (int j = 0; j < 4; j++)
                {
                    if (i != j && KullaniciTahmini.dizi[i] == BilgisayarınTuttuguSayi.dizi[j]) //eşleşen sayı miktarı kontrolü
                    {
                        KullaniciTahmini.EslesenSayiMiktari++;
                    }
                }
            }
            txtKullaniciArti.Text = "" + KullaniciTahmini.EslesenBasamakMiktari;
            txtKullaniciEksi.Text = "" + KullaniciTahmini.EslesenSayiMiktari;
        }



        /// <summary>
        /// bilgisayara basamakları birbirinden farklı 4 basamaklı sayı ürettirme
        /// </summary>
        public void RastgeleSayiUret()
        {
            Random uretilenSayi = new Random();
            int i = 0;
            while (i < 4)
            {
                if (i == 0)
                {
                    BilgisayarınTuttuguSayi.dizi[i] = uretilenSayi.Next(10);
                    i++;
                }
                else
                {
                    int a;
                    a = uretilenSayi.Next(10);
                    if (a == 0 && i == 3)
                    {
                        a += 1;
                    }
                    if (Bul(a, i, BilgisayarınTuttuguSayi.dizi) == false)
                    {
                        BilgisayarınTuttuguSayi.dizi[i] = a;
                        i++;
                    }
                }

            }
            BilgisayarınTuttuguSayi.sayi = BilgisayarınTuttuguSayi.dizi[0] + BilgisayarınTuttuguSayi.dizi[1] * 10 + BilgisayarınTuttuguSayi.dizi[2] * 100 + BilgisayarınTuttuguSayi.dizi[3] * 1000;
        }

        /// <summary>
        /// dizide basmak kontrolü
        /// </summary>
        /// <param name="aranan">kontrol edilcek sayı</param>
        /// <param name="oncekiBasamakSayisi"> kontrol edilecek basamak sayısı</param>
        /// <param name="dizi">kontrol edilecek dizi</param>
        /// <returns></returns>
        public Boolean Bul(int aranan, int oncekiBasamakSayisi, int[] dizi)
        {
            for (int i = 0; i < oncekiBasamakSayisi + 1; i++)
            {
                if (aranan == dizi[i])
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region butonclikler

        private void btnOyunuBaslatYenidenBaslat_Click(object sender, EventArgs e)
        {
            RastgeleSayiUret();

            btnKullaniciTahmin.Enabled = true;
            btnBilgisayaraTahminYaptir.Enabled = false;
            btnOyunuBaslatYenidenBaslat.Enabled = false;
            btnBilgisayarınTahminEttigiSayiyiSifirla.Enabled = true;
        }

        private void btnBilgisayarınTahminEttigiSayiyiSifirla_Click(object sender, EventArgs e)
        {
            BilgisayarRastgeleSayiUret();//kullanının aklında tuttugu sayının ilk olarak tahmini 
            txtBilgisayarTahmini.Text = BilgisayarınUrettigiSayi.sayi.ToString();
            EskiBasamakElemanlari.Clear();
            Karaliste.Clear();
            BeyazListe.Clear();
            KesinListe.Clear();
            btnOyunuBaslatYenidenBaslat.Enabled = true;
            btnBilgisayarınTahminEttigiSayiyiSifirla.Enabled = false;
        }

        private void btnKullaniciTahmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciTahmini.Text))
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz");
            }
            else
            {
                KullaniciTahmini.EslesenBasamakMiktari = 0;
                KullaniciTahmini.EslesenSayiMiktari = 0;
                KullaniciTahmin();


                if (BilgisayarTahminleriListesi.Count < 1)
                {
                    BilgisayarRastgeleSayiUret();
                    BilgisayarTahminleriListesi.Add(BilgisayarınUrettigiSayi);
                    txtBilgisayarTahmini.Text = BilgisayarınUrettigiSayi.sayi.ToString();
                }
                btnKullaniciTahmin.Enabled = false;
                btnBilgisayaraTahminYaptir.Enabled = true;
                if (KullaniciTahmini.EslesenBasamakMiktari == 4)
                {
                    btnBilgisayaraTahminYaptir.Enabled = false;
                    btnKullaniciTahmin.Enabled = false;
                    MessageBox.Show("Tebrikler Kullanıcı Kazandı");

                }

            }

        }

        private void btnBilgisayaraTahminYaptir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBilgisayarEksi.Text) || string.IsNullOrEmpty(txtBilgisayarArti.Text))
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz");
            }
            else
            {
                if (counter == 0)
                {



                    BilgisayarınUrettigiSayi.EslesenBasamakMiktari = Convert.ToInt32(txtBilgisayarArti.Text);
                    BilgisayarınUrettigiSayi.EslesenSayiMiktari = Convert.ToInt32(txtBilgisayarEksi.Text);

                    //form load olduğunda bilgisayar ilk tahmini yaptı burda tahminin + ve - değerleri girildi


                    ipucunaGoreYeniSayiUret();
                    Suaneslesmebasamak = Convert.ToInt32(txtBilgisayarArti.Text);
                    Suaneslesmesayi = Convert.ToInt32(txtBilgisayarEksi.Text);

                    BilgisayarınUrettigiSayi.sayi = BilgisayarınUrettigiSayi.dizi[0] + BilgisayarınUrettigiSayi.dizi[1] * 10 + BilgisayarınUrettigiSayi.dizi[2] * 100 + BilgisayarınUrettigiSayi.dizi[3] * 1000;

                    txtBilgisayarTahmini.Text = BilgisayarınUrettigiSayi.sayi.ToString();

                }
                if (counter > 0)
                {

                    Suaneslesmebasamak = Convert.ToInt32(txtBilgisayarArti.Text);
                    Suaneslesmesayi = Convert.ToInt32(txtBilgisayarEksi.Text);
                    if (Suaneslesmebasamak != 4)
                    {
                        SayaclariKontrolEt();
                        ipucunaGoreYeniSayiUret();

                        BilgisayarınUrettigiSayi.EslesenBasamakMiktari = Suaneslesmebasamak;
                        BilgisayarınUrettigiSayi.EslesenSayiMiktari = Suaneslesmesayi;

                        txtBilgisayarTahmini.Text = BilgisayarınUrettigiSayi.sayi.ToString();
                        BilgisayarınUrettigiSayi.sayi = BilgisayarınUrettigiSayi.dizi[0] + BilgisayarınUrettigiSayi.dizi[1] * 10 + BilgisayarınUrettigiSayi.dizi[2] * 100 + BilgisayarınUrettigiSayi.dizi[3] * 1000;

                    }
                }
                counter++;
                BilgisayarınUrettigiSayi.sayi = BilgisayarınUrettigiSayi.dizi[0] + BilgisayarınUrettigiSayi.dizi[1] * 10 + BilgisayarınUrettigiSayi.dizi[2] * 100 + BilgisayarınUrettigiSayi.dizi[3] * 1000;

                txtBilgisayarTahmini.Text = BilgisayarınUrettigiSayi.sayi.ToString();
                btnKullaniciTahmin.Enabled = true;
                btnBilgisayaraTahminYaptir.Enabled = false;
                if (Suaneslesmebasamak == 4)
                {
                    MessageBox.Show("Üzgünüz Bilgisayar Kazandı");
                    btnKullaniciTahmin.Enabled = false;
                    btnBilgisayaraTahminYaptir.Enabled = false;
                }
            }
        }

        #endregion

        #region bilgisayar tahmini

        Sayi BilgisayarınUrettigiSayi = new Sayi(); // her yerden erişim sağlanabilsin diye global bi sayı nesnesi üretilmiştir 

        #region kullanıcının aklında tuttuğu sayıyı bilgisayarın üretmesi
        /// <summary>
        /// kullanıcının aklında tuttğu sayıyı ilk olarak bilgisayarın tahmin etmesi
        /// </summary>
        public void BilgisayarRastgeleSayiUret()//  bilgisayaar rastgele sayı üretir
        { //üretilen sayı aşağıda belli kontrollere göre öüretilir
            Random uretilenSayi = new Random();
            int i = 0;
            while (i < 4)
            {
                if (i == 0)
                {
                    BilgisayarınUrettigiSayi.dizi[i] = uretilenSayi.Next(10);//üretilen sayı eğer birler basaamağında ve ilk sayı üretilir
                    i++;
                }
                else
                {
                    int a;
                    a = uretilenSayi.Next(10);
                    if (a == 0 && i == 3)
                    {
                        a += 1; //üretilen sayı 0 ve basmaak binler ise sayı üretilen sayı 1 artsın
                    }
                    if (Bul(a, i, BilgisayarınUrettigiSayi.dizi) == false)// üretilen sayı kendinden önceki basmaakta var mı kontrolü
                    {
                        BilgisayarınUrettigiSayi.dizi[i] = a;
                        i++;
                    }
                }

            }
            BilgisayarınUrettigiSayi.sayi = BilgisayarınUrettigiSayi.dizi[0] + BilgisayarınUrettigiSayi.dizi[1] * 10 + BilgisayarınUrettigiSayi.dizi[2] * 100 + BilgisayarınUrettigiSayi.dizi[3] * 1000;

        }
        /// <summary>
        /// kullanıcının girdiği ipucuna göre yeni sayı üretilir
        /// </summary>
        public void ipucunaGoreYeniSayiUret()
        {


            Random rnd = new Random();  // rastgele sayı üretebilmek için random classından bi nesne türetilmiştir
            while (true) // sayı üretirken sonsuz bir döngü oluşturulmuştur. isntenilen koşul sağlanana kadar sayı  üretilir
            {
                sayac++;
                if (sayac > 1000)
                {
                    MessageBox.Show("sonzsuz döngü");
                    break;
                }
                uretilenSayi = rnd.Next(10); // random.next metodu ile  0 dan 9 a kadar bir sayı üretilmiştir.
                if (basamak == 3 && uretilenSayi == 0)//üretilen sayı ve sayının basamak değeri sıfır ise yeniden sayı üretilcek
                {
                }
                else
                {

                    if (ListeKontrolEt(uretilenSayi, EskiBasamakElemanlari) == false && ListeKontrolEt(uretilenSayi, Karaliste) == false && ListeKontrolEt(uretilenSayi, KesinListe) == false /*&& Bul(uretilenSayi, basamak, BilgisayarınUrettigiSayi.dizi) == false */)
                    {
                        // istenilen koşul üretilen sayı karalistede yok ,eski bas eleman listede  yok ise yeni sayı üretilir

                        degisenSayi = BilgisayarınUrettigiSayi.dizi[basamak];
                        BilgisayarınUrettigiSayi.dizi[basamak] = uretilenSayi;
                        // üstteki 2 satırda ise  en son sayı üretilmeden o basamakta var olan sayı bir değişkende daha sonraki kontrollerde değerlendirilmek için bir değişkene atanır
                        break; // koşul sağlandığında break yardımı ile döngüden çıkılır
                    }
                }
            }
        } // ipucuna göre üretme

        /// <summary>
        /// global olarak tutulan sayaçların kontrol işlemi
        /// </summary>
        public void SayaclariKontrolEt()
        {
            if (Suaneslesmebasamak > BilgisayarınUrettigiSayi.EslesenBasamakMiktari) // suan eşleşen basamak miktarı artarsa
            {
                if (Suaneslesmesayi == BilgisayarınUrettigiSayi.EslesenSayiMiktari)
                {
                    // eşleşen basmak miktarı arttı ve esleşen sayı miktarı sabit kaldı ise
                    // değişen sayı basmak kalisteye atılır
                    ListeyeElemanEkle(degisenSayi, Karaliste);
                    // yeni(üretilen) basamak kesin listeye atılır
                    ListeyeElemanEkle(uretilenSayi, KesinListe);
                    // uretilen sayı nihai basamak değeri yapılır.
                    BilgisayarınUrettigiSayi.dizi[basamak] = uretilenSayi;

                }
                if (Suaneslesmesayi < BilgisayarınUrettigiSayi.EslesenSayiMiktari)
                {
                    //eğer eşleşen basamak miktarı artar ve eşleşen sayı miktarı azalırsa 
                    // üretilen sayı kesin listeye atılır
                    ListeyeElemanEkle(uretilenSayi, KesinListe);
                    // değişen sayı beyaz listeye atılır ve eski bas listesine atılır
                    ListeyeElemanEkle(degisenSayi, BeyazListe);
                    ListeyeElemanEkle(degisenSayi, EskiBasamakElemanlari);
                    //üretilen sayi nihai basamak değeri olur
                    BilgisayarınUrettigiSayi.dizi[basamak] = uretilenSayi;

                }
                //basamk değişkeni 1 artar
                basamak++;
                EskiBasamakElemanlari.Clear();
            }
            if (Suaneslesmebasamak < BilgisayarınUrettigiSayi.EslesenBasamakMiktari) // şuan eşleşen basmak miktarı azalırsa
            {
                //üretilen sayi kara listeye atılır
                ListeyeElemanEkle(uretilenSayi, Karaliste);

                if (Suaneslesmesayi == BilgisayarınUrettigiSayi.EslesenSayiMiktari)
                {
                    // şuan eşleşen basmak miktarı azalırsa ve şuan eşeleşn sayı miktarı değişmezse
                    // değişen sayı kesin listeye atılır
                    ListeyeElemanEkle(degisenSayi, KesinListe);
                    ListeyeElemanEkle(uretilenSayi, EskiBasamakElemanlari);
                }
                if (Suaneslesmesayi > BilgisayarınUrettigiSayi.EslesenSayiMiktari)
                {
                    // şuan eşleşen basmak miktarı azalırsa ve şuan eşeleşn sayı miktarı artarsa
                    // değişen sayı beyaz listeye atılır ve eski bas elemanlarına atılır
                    ListeyeElemanEkle(degisenSayi, BeyazListe);
                    ListeyeElemanEkle(degisenSayi, EskiBasamakElemanlari);


                }
                // değişen sayı nihai bsamak değeri yapılır
                BilgisayarınUrettigiSayi.dizi[basamak] = degisenSayi;
                //basamak değişkeni 1 artırılır
                basamak++;
                EskiBasamakElemanlari.Clear();
            }
            if (Suaneslesmebasamak == BilgisayarınUrettigiSayi.EslesenBasamakMiktari)  // suan eşleşen basamak miktarı değişmezse
            {

                if (Suaneslesmesayi > BilgisayarınUrettigiSayi.EslesenSayiMiktari)
                {
                    // eşleşen basamak miktarı değişmez ve eşleşen sayı miktarı artarsa
                    // üretilen sayı eske bas ele. listeye ve beyaz listeye atılır
                    ListeyeElemanEkle(uretilenSayi, BeyazListe);
                    ListeyeElemanEkle(degisenSayi, EskiBasamakElemanlari);
                    ListeyeElemanEkle(uretilenSayi, EskiBasamakElemanlari);
                    // değişen sayı karalisteye atılır
                    ListeyeElemanEkle(degisenSayi, Karaliste);
                    //basamak değişkeni değişmez
                }
                if (Suaneslesmesayi < BilgisayarınUrettigiSayi.EslesenSayiMiktari)
                {
                    // eşleşen basamak miktarı değişmez ve eşleşen sayı miktarı azalırsa
                    // üretilen sayı kara listeye atılır
                    ListeyeElemanEkle(uretilenSayi, Karaliste);
                    // değişen sayı eski bas elem.  listeye atılır
                    ListeyeElemanEkle(degisenSayi, EskiBasamakElemanlari);
                    ListeyeElemanEkle(uretilenSayi, EskiBasamakElemanlari);
                    ListeyeElemanEkle(uretilenSayi, BeyazListe);
                    //basamak değişkeni değişmez
                }
                if (Suaneslesmesayi == BilgisayarınUrettigiSayi.EslesenSayiMiktari)
                {
                    // // eşleşen basamak miktarı değişmez ve eşleşen sayı miktarı değişmezse
                    // herhangi bir yargı konulamaz 2 sayı hem beyaz listede olabilir hem de kara listede

                    ListeyeElemanEkle(degisenSayi, EskiBasamakElemanlari);
                    ListeyeElemanEkle(uretilenSayi, EskiBasamakElemanlari);
                }

            }

        }

        #endregion

        #endregion

        #region textbox lar ait keypres eventları

        private void txtKullaniciTahmini_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //textbox a sadece srakam girişi yapılmasını sağlar
            if (txtKullaniciTahmini.TextLength == 4) // textbox ın 4 karakter girşi ile sınırlanmasını sağlar
            {
                e.Handled = true;
            }
        }

        private void txtBilgisayarArti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//textbox a sadece srakam girişi yapılmasını sağlar
            if (txtBilgisayarArti.TextLength == 1) // textbox ın 1 karakter girşi ile sınırlanmasını sağlar
            {
                e.Handled = true;
            }
        }

        private void txtBilgisayarEksi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//textbox a sadece srakam girişi yapılmasını sağlar
            if (txtBilgisayarEksi.TextLength == 1)  // textbox ın 1 karakter girşi ile sınırlanmasını sağlar
            {
                e.Handled = true;
            }
        }
        #endregion

        #region liste işlemleri

        /// <summary>
        /// herhangi bir listeye eleman ekleme
        /// </summary>
        /// <param name="eklenecek"> listeye eklenecek eleman</param>
        /// <param name="liste">elemanın ekleneceği liste</param>
        public void ListeyeElemanEkle(int eklenecek, List<int> liste)
        {
            if (ListeKontrolEt(eklenecek, liste) == false) // eğer listede eleman yok ise eklenir
            {
                liste.Add(eklenecek);
            }
        }
        /// <summary>
        /// herhangi bir listeden eleman çıkarma
        /// </summary>
        /// <param name="cikacak"> listeden çıkarılacak eleman</param>
        /// <param name="liste">elemanın çıkarılacağı liste</param>
        public void ListedenElemanCikar(int cikacak, List<int> liste)
        {
            if (ListeKontrolEt(cikacak, liste) == true)
            {
                liste.Remove(cikacak);
            }
        }

        /// <summary>
        /// listenin elemanlarının kontrolü işlemi
        /// </summary>
        /// <param name="aranan"> listede aranacak eleman</param>
        /// <param name="liste">elemanın aranacağı liste</param>
        /// <returns></returns>
        public Boolean ListeKontrolEt(int aranan, List<int> liste)
        {
            foreach (var item in liste)
            {
                if (item == aranan) // listede elemana rastlanırsa true hiç rastlanmazsa false döner
                {
                    return true;
                }
            }

            return false;

        }
        #endregion





    }
}
