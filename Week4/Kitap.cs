using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    //sınıf
    class Kitap
    {
        //Sınıf üyesi/class members

        #region Fields/alanlar
        //Fields/alanlar/nonstatik
        private string kitapAdi;
        private string yazar;
        private int yayinYili;
        private List<String> sayfalar;
        //Fields/alanlar/statik
        public static int toplamKitapSayisi = 0;
        #endregion

        #region Properties/Özellikler
        //Properties/Özellikler
        public string KitapAdi
        {
            get { return kitapAdi; }
            set { kitapAdi = value; }
        }
        public string Yazar
        {
            get { return yazar; }
            set { yazar = value; }
        }

        public int YayinYili
        {
            get { return yayinYili; }
            set
            {
                if (value > 0 && value <= DateTime.Now.Year)
                    yayinYili = value;
                else
                    throw new ArgumentException("Geçersiz yayın yılı!");
            }
        }
        public string KapakRengi { get; set; } = "Beyaz";




        #endregion

        #region Yapıcı metotlar/constructor
        //yapıcı metotlar/constructor
        //default constructor
        public Kitap()
        {
            kitapAdi = "Bilinmeyen Kitap";
            yazar = "Bilinmeyen Yazar";
            yayinYili = DateTime.Now.Year;
            sayfalar = new List<string>();
            toplamKitapSayisi++;
            Console.WriteLine("Yeni bir kitap oluşturuldu (Varsayılan yapıcı).");
        }

        //aşırı yüklenmiş/overloaded constructor
        public Kitap(string kitapAdi, string yazar)
        {
            toplamKitapSayisi++;
            this.kitapAdi = kitapAdi;
            this.yazar = yazar;
            sayfalar = new List<string>();
            Console.WriteLine("Yeni bir kitap oluşturuldu (Aşırı yüklenmiş yapıcı).");
        }
        //aşırı yüklenmiş/overloaded constructor
        public Kitap(string kitapAdi, string yazar, int yayinYili)
        {
            toplamKitapSayisi++;
            this.kitapAdi = kitapAdi;
            this.yazar = yazar;
            this.yayinYili = yayinYili;
            sayfalar = new List<string>();
            Console.WriteLine("Yeni bir kitap oluşturuldu (Aşırı yüklenmiş yapıcı).");
        }
        #endregion

        #region Methods (Metotlar)
        // Methods (Metotlar)
        public void SayfaEkle(string sayfaIcerigi)
        {
            sayfalar.Add(sayfaIcerigi);
            Console.WriteLine($"Sayfa eklendi. Toplam sayfa sayısı: {sayfalar?.Count}");
        }

        public void KitapBilgileriniGoster()
        {
            Console.WriteLine($"Kitap: {KitapAdi}, Yazar: {Yazar}, Yayın Yılı: {YayinYili}, Toplam Sayfa: {sayfalar?.Count}");
        }

        public static int ToplamKitapSayisi()
        {
            return toplamKitapSayisi;
        }
        #endregion

        #region Indexer (İndeksleyici)
        // Indexer (İndeksleyici)
        // Kitabın sayfalarına indeksleyici ile erişim sağlar

        public string this[int sayfaNumarasi]
        {
            get
            {
                if (sayfaNumarasi >= 0 && sayfaNumarasi < sayfalar.Count)
                    return sayfalar[sayfaNumarasi];
                else
                    return "Geçersiz sayfa numarası!";
            }
            set
            {
                if (sayfaNumarasi >= 0 && sayfaNumarasi < sayfalar.Count)
                    sayfalar[sayfaNumarasi] = value;
                else
                    sayfalar[sayfaNumarasi] = "Boş";
            }
        }

        #endregion

        #region Destructor (Yıkıcı Metot)
        // C#'ta yıkıcılar, Garbage Collector tarafından çağrılır ve kaynak temizliği için kullanılır.

        ~Kitap()
        {
            toplamKitapSayisi--;
            Console.WriteLine("Kitap nesnesi bellekten silindi.");
        }

        #endregion
    }
}
