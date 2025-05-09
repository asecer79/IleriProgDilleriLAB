
using Week12;

namespace Week12
{


    #region Delegeler Örnekler


    /*
     C# delegeleri, metot referanslarını tutabilen ve onları çağırabilen özel tür tanımlayıcılardır:

    Temel Delegeler - 

    Basit delegate tanımları ve kullanımları
    Parametreli ve değer döndüren delegeler
    Multicast (çoklu çağrı) delegeler
    Sınıf metotlarıyla çalışan delegeler
    Anonim metotlarla delegate kullanımı
    Metot parametresi olarak delegeler


     */


    public class Program1
    {
        // Temel bir delegate tanımı - parametresiz ve geri dönüş değeri olmayan bir fonksiyonu işaret eder
        // Delegeler, metot referanslarını tutan ve çağırabilen tiplerdir
        public delegate void BasitDelegate();

        // Parametre alan ve geriye değer döndürmeyen bir delegate tanımı
        public delegate void ParametreliDelegate(string mesaj);

        // İki parametre alan ve geriye int değer döndüren bir delegate tanımı
        public delegate int HesaplamaDelegate(int sayi1, int sayi2);

        // Bir sınıf metodu ile çalışabilen delegate tanımı
        public delegate void KompleksIslemDelegate(Kisi kisi, int miktar);


        static void Main1(string[] args)
        {
            /*
            Console.WriteLine("C# Delegeleri Örnekleri\n");

            // ÖRNEK 1: Basit delegate örneği
            // ============================
            Console.WriteLine("### ÖRNEK 1: Basit delegate kullanımı ###");

            // BasitDelegate tipinde bir değişken oluşturuyoruz
            BasitDelegate selamVer = Selamlama;

            // Delegate üzerinden metot çağrısı yapıyoruz
            selamVer();

           */

            /*
            // ÖRNEK 2: Parametreli delegate örneği
            // ============================
            Console.WriteLine("### ÖRNEK 2: Parametreli delegate kullanımı ###");

            // ParametreliDelegate tipinde değişken oluşturuyoruz
            ParametreliDelegate mesajGoster = MesajYazdir;

            // Delegate üzerinden parametre göndererek metot çağrısı yapıyoruz
            mesajGoster("Merhaba, delegeler dünyasına hoş geldiniz!");

            Console.WriteLine();

            */

            /*

            // ÖRNEK 3: Hesaplama yapan delegate örneği
            // ============================
            Console.WriteLine("### ÖRNEK 3: Değer döndüren delegate kullanımı ###");

            // HesaplamaDelegate tipinde değişkenler oluşturup farklı metotlarla ilişkilendiriyoruz
            HesaplamaDelegate topla = new HesaplamaDelegate(Toplama);
            HesaplamaDelegate cikar = new HesaplamaDelegate(Cikarma);
            HesaplamaDelegate carp = new HesaplamaDelegate(Carpma);

            // Delege üzerinden hesaplama işlemleri yapıyoruz
            int sonuc1 = topla(10, 5);
            int sonuc2 = cikar(20, 7);
            int sonuc3 = carp(5, 6);

            Console.WriteLine($"Toplama sonucu: {sonuc1}");
            Console.WriteLine($"Çıkarma sonucu: {sonuc2}");
            Console.WriteLine($"Çarpma sonucu: {sonuc3}");

            Console.WriteLine();
            */

            /*
            // ÖRNEK 4: Multicast (çoklu çağrı) delegate örneği
            // ============================
            Console.WriteLine("### ÖRNEK 4: Multicast delegate kullanımı ###");

            // Bir delegate'e birden fazla metot ekleyerek çoklu çağrı yapabiliriz
            ParametreliDelegate bildirimYoneticisi = LogYaz;

            // += operatörü ile delegate'e yeni metotlar ekliyoruz
            bildirimYoneticisi += EmailGonder; //binding
            bildirimYoneticisi += SmsGonder;

            // Tek bir çağrı ile tüm eklenen metotlar sırayla çalıştırılır
            bildirimYoneticisi("Sistem bakıma alınıyor!");

            // -= operatörü ile delegate'den metot çıkarabiliriz
            Console.WriteLine("\nSMS bildirimi kaldırıldıktan sonra:");
            bildirimYoneticisi -= SmsGonder;  //remove binding
            bildirimYoneticisi("Bakım işlemi tamamlandı.");

            Console.WriteLine();
            */

            /*
            // ÖRNEK 5: Nesne metoduyla çalışan delegate örneği
            // ============================
            Console.WriteLine("### ÖRNEK 5: Sınıf metotlarıyla çalışan delegate ###");

            // Bir Kisi nesnesi oluşturuyoruz
            Kisi musteri = new Kisi { Ad = "Ahmet", Soyad = "Yılmaz", Bakiye = 1000 };

            // Nesne metodunu işaret eden delegate oluşturuyoruz
            KompleksIslemDelegate hesapIslem = musteri.ParaYatir;

            // Delegate üzerinden nesne metodunu çağırıyoruz
            hesapIslem(musteri, 500);

            // Aynı delegate'i farklı bir metotla ilişkilendirip çağırıyoruz
            hesapIslem = musteri.ParaCek;
            hesapIslem(musteri, 300);

            Console.WriteLine();

            */


            /*
            // ÖRNEK 6: Anonim metot ile delegate kullanımı
            // ============================
            Console.WriteLine("### ÖRNEK 6: Anonim metot ile delegate kullanımı ###");

            // Delegate için anonim metot tanımlıyoruz (Action veya Func kullanmadan)
            HesaplamaDelegate bolme = delegate (int a, int b) {
                if (b == 0)
                    return 0;
                return a / b;
            };

            // Anonim metot ile oluşturulan delegate'i çağırıyoruz
            int bolmeSonucu = bolme(100, 4);
            Console.WriteLine($"Bölme sonucu: {bolmeSonucu}");

            // Bir başka anonim metot örneği
            ParametreliDelegate tarihYazdir = delegate (string format) {
                Console.WriteLine($"Şu anki tarih ({format}): {DateTime.Now.ToString(format)}");
            };

            tarihYazdir("dd.MM.yyyy HH:mm");

            Console.WriteLine();
            */

            /*
            // ÖRNEK 7: Metot parametresi olarak delegate kullanımı
            // ============================
            Console.WriteLine("### ÖRNEK 7: Metot parametresi olarak delegate kullanımı ###");

            // Delegate'i bir metoda parametre olarak gönderiyoruz
            DiziIslemYap(new int[] { 3, 7, 12, 19, 6, 22 }, IkiyleCarp);
            DiziIslemYap(new int[] { 3, 7, 12, 19, 6, 22 }, Karesi);
            //DiziIslemYap(new int[] { 3, 7, 12, 19, 6, 22 }, Cikarma);

            Console.WriteLine();

            Console.ReadKey();
            */





        }


        // ÖRNEK METOTlar

        // BasitDelegate için örnek metot
        static void Selamlama()
        {
            Console.WriteLine("Merhaba, ben bir delegeyle çağrılan metodum!");
        }

        // ParametreliDelegate için örnek metot
        static void MesajYazdir(string mesaj)
        {
            Console.WriteLine($"MESAJ: {mesaj}");
        }

        // HesaplamaDelegate için örnek metotlar
        static int Toplama(int x, int y)
        {
            return x + y;
        }

        static int Cikarma(int x, int y)
        {
            return x - y;
        }

        static int Carpma(int x, int y)
        {
            return x * y;
        }

        // Multicast delegate için örnek metotlar
        static void LogYaz(string mesaj)
        {
            Console.WriteLine($"LOG: {mesaj}");
        }

        static void EmailGonder(string mesaj)
        {
            Console.WriteLine($"E-POSTA: {mesaj} (e-posta gönderildi)");
        }

        static void SmsGonder(string mesaj)
        {
            Console.WriteLine($"SMS: {mesaj} (sms gönderildi)");
        }

        // Dizi işlemleri için delegate kullanımı
        static void DiziIslemYap(int[] sayilar, HesaplamaDelegate islem)
        {
            Console.WriteLine("Dizi işlem sonuçları:");
            foreach (int sayi in sayilar)
            {
                // Her sayı için delegate ile işlem yapıyoruz
                int sonuc = islem(sayi, 2);
                Console.Write($"{sonuc} ");
            }
            Console.WriteLine();
        }

        // Dizi işlemleri için kullanılan metotlar
        static int IkiyleCarp(int sayi, int carpan)
        {
            return sayi * carpan;
        }

        static int Karesi(int sayi, int _)
        {
            return sayi * sayi;
        }
    }


    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Bakiye { get; set; }

        public void ParaYatir(Kisi kisi, int miktar)
        {
            kisi.Bakiye += miktar;
            Console.WriteLine($"{kisi.Ad} {kisi.Soyad}'ın hesabına {miktar} TL yatırıldı. Yeni bakiye: {kisi.Bakiye} TL");
        }

        public void ParaCek(Kisi kisi, int miktar)
        {
            if (kisi.Bakiye >= miktar)
            {
                kisi.Bakiye -= miktar;
                Console.WriteLine($"{kisi.Ad} {kisi.Soyad}'ın hesabından {miktar} TL çekildi. Yeni bakiye: {kisi.Bakiye} TL");
            }
            else
            {
                Console.WriteLine($"İşlem başarısız: Yetersiz bakiye! Mevcut bakiye: {kisi.Bakiye} TL");
            }
        }
    }


    #endregion

    #region Delegeler İleri Örnekler

    // Olaya dönüştürülebilen delegate tanımı
    // Konvansiyonel olarak 'EventHandler' şeklinde adlandırılır
    public delegate void VeriDegistiEventHandler(object sender, VeriDegistiEventArgs e);
    class Program2
    {


        // Koşullu filtreleme için kullanılacak delegate
        public delegate bool FiltreDelegate<T>(T item);

        // Genericleştirilmiş delegate tanımı - Action/Func kullanmadan
        public delegate TOutput DonusturuDelegate<TInput, TOutput>(TInput input);

        // Metin işleme işlemlerini gerçekleştiren delegeler
        public delegate string MetinIslemDelegate(string metin);

        static void Main2(string[] args)
        {
            Console.WriteLine("C# Delegeleri İleri Seviye Örnekler\n");

            // ÖRNEK 1: Olay (Event) Kullanımı
            // ============================
            Console.WriteLine("### ÖRNEK 1: Olaylarda (Event) Delegelerin Kullanımı ###");

            // VeriDeposu nesnesi oluşturup olayına abone olma
            VeriDeposu veriDeposu = new VeriDeposu();

            // Olaya metotları abone ediyoruz
            veriDeposu.VeriDegisti += VeriDegistiHandler;
            veriDeposu.VeriDegisti += LogaKaydet;

            // Veri değişikliği yaparak olayı tetikliyoruz
            veriDeposu.Veri = "Yeni veri değeri";
            veriDeposu.Veri = "Başka bir değer";

            // Abonelikten çıkıp tekrar değişim yapıyoruz
            veriDeposu.VeriDegisti -= LogaKaydet;
            veriDeposu.Veri = "Abonelik sonrası değer";

            Console.WriteLine();


            // ÖRNEK 2: Callback Fonksiyonları (Geri Çağırma)
            // ============================
            Console.WriteLine("### ÖRNEK 2: Callback (Geri Çağırma) Fonksiyonları ###");

            // Uzun süren bir işlemi simüle eden metodu çağırıyoruz
            // ve tamamlandığında çalışacak callback metodu delegate olarak geçiyoruz
            Console.WriteLine("İşlem başlatılıyor...");

            // İşlevi ve tamamlandığında çağrılacak callback'i tanımlıyoruz
            UzunSurenIslem(5, IslemTamamlandi);

            Console.WriteLine("Ana program akışı devam ediyor...");
            System.Threading.Thread.Sleep(1000); // Callback'in çalıştığını görebilmek için bekliyoruz

            Console.WriteLine();


            // ÖRNEK 3: Delegeler ile Koleksiyon Filtreleme
            // ============================
            Console.WriteLine("### ÖRNEK 3: Delegeler ile Koleksiyon Filtreleme ###");

            List<Urun> urunler = new List<Urun>()
            {
                new Urun { Id = 1, Ad = "Laptop", Fiyat = 15000, Stok = 10 },
                new Urun { Id = 2, Ad = "Telefon", Fiyat = 8000, Stok = 25 },
                new Urun { Id = 3, Ad = "Tablet", Fiyat = 5000, Stok = 5 },
                new Urun { Id = 4, Ad = "Kulaklık", Fiyat = 1000, Stok = 50 },
                new Urun { Id = 5, Ad = "Kamera", Fiyat = 12000, Stok = 8 }
            };

            // Farklı filtreleme işlemleri için delegate'leri tanımlıyoruz
            FiltreDelegate<Urun> pahaliFiltreleme = PahaliUrunler;
            FiltreDelegate<Urun> stokAzFiltreleme = StokAzUrunler;

            // Filtreleme metodunu çağırıyoruz
            List<Urun> pahaliUrunler = FiltreleUrunler(urunler, pahaliFiltreleme);
            List<Urun> stokAzUrunler = FiltreleUrunler(urunler, stokAzFiltreleme);

            // İki filtreyi birleştiren yeni bir delegate
            FiltreDelegate<Urun> pahaliVeStokAz = delegate (Urun u)
            {
                return PahaliUrunler(u) && StokAzUrunler(u);
            };

            List<Urun> pahaliVeStokAzUrunler = FiltreleUrunler(urunler, pahaliVeStokAz);

            // Sonuçları görüntüleme
            Console.WriteLine("Pahalı Ürünler:");
            UrunleriGoster(pahaliUrunler);

            Console.WriteLine("\nStok Durumu Az Ürünler:");
            UrunleriGoster(stokAzUrunler);

            Console.WriteLine("\nHem Pahalı Hem Stok Durumu Az Ürünler:");
            UrunleriGoster(pahaliVeStokAzUrunler);

            Console.WriteLine();


            // ÖRNEK 4: Delegeler ile Veri Dönüşümü
            // ============================
            Console.WriteLine("### ÖRNEK 4: Delegeler ile Veri Dönüşümü ###");

            // Çeşitli veri dönüşüm işlemleri için delegate tanımları
            DonusturuDelegate<string, int> stringToInt = StringiSayiyaDonustur;
            DonusturuDelegate<int, string> intToString = SayiyiStringeDonustur;
            DonusturuDelegate<string, string> buyukHarf = BuyukHarfeDonustur;

            // Örnek dönüşüm işlemleri
            string[] metinler = { "123", "456", "789", "0" };

            Console.WriteLine("Metin -> Sayı -> Metin dönüşümü:");
            foreach (var metin in metinler)
            {
                // Zincirleme delegate çağrımı - Composition
                int sayi = stringToInt(metin);
                string sonuc = intToString(sayi);
                Console.WriteLine($"'{metin}' -> {sayi} -> '{sonuc}'");
            }

            // Genericleştirilmiş dönüştürme yöntemi kullanımı
            List<string> isimler = new List<string> { "ahmet", "mehmet", "ayşe", "fatma" };
            List<string> buyukHarfliIsimler = ListeyiDonustur(isimler, buyukHarf);

            Console.WriteLine("\nBüyük harfe dönüştürülmüş isimler:");
            foreach (var isim in buyukHarfliIsimler)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine();


            // ÖRNEK 5: Delegeler ile Çalışan İşleme Pipeline'ı
            // ============================
            Console.WriteLine("### ÖRNEK 5: Delegeler ile İşleme Pipeline'ı ###");



            // İşlem adımlarını içeren delegeleri tanımlama
            MetinIslemDelegate boslukKaldir = BosluklariKaldir;
            MetinIslemDelegate buyukHarfYap = BuyukHarfeDonustur;
            MetinIslemDelegate tireBirlestir = TireleBirlestir;

            // Pipeline oluşturuyoruz (işlem zinciri)
            MetinIslemDelegate islemPipeline = boslukKaldir;
            islemPipeline += buyukHarfYap;
            islemPipeline += tireBirlestir;

            // Test metni
            string testMetni = "Bu bir örnek metin içeriğidir ve işlenecek";

            // Pipeline işlemi sırayla uygulama (her adımı ayrı göstermek için)
            Console.WriteLine($"Orijinal Metin: {testMetni}");
            string adim1 = boslukKaldir(testMetni);
            Console.WriteLine($"Adım 1 (Boşluk Kaldır): {adim1}");
            string adim2 = buyukHarfYap(adim1);
            Console.WriteLine($"Adım 2 (Büyük Harf): {adim2}");
            string adim3 = tireBirlestir(adim2);
            Console.WriteLine($"Adım 3 (Tire Ekle): {adim3}");

            // Tüm pipeline'ı tek seferde uygulama (yeni bir pipeline ile)
            MetinIslemDelegate tekAdimPipeline =
                metin => tireBirlestir(buyukHarfYap(boslukKaldir(metin)));

            string sonuc2 = tekAdimPipeline(testMetni);
            Console.WriteLine($"Tek Adımda Pipeline Sonucu: {sonuc2}");

            Console.ReadKey();


        }


        // ÖRNEK METOTlar

        // Örnek 1 için olay işleyici metotları
        static void VeriDegistiHandler(object sender, VeriDegistiEventArgs e)
        {
            Console.WriteLine($"Veri değişti: {e.EskiVeri} -> {e.YeniVeri}");
        }

        static void LogaKaydet(object sender, VeriDegistiEventArgs e)
        {
            Console.WriteLine($"LOG: Veri değişikliği kaydedildi - {DateTime.Now}");
        }

        // Örnek 2 için callback metotları
        static void UzunSurenIslem(int saniye, Action<bool, string> islemTamamlandiCallback)
        {
            // Asenkron işlemi simüle etmek için ayrı bir thread kullanıyoruz
            System.Threading.ThreadPool.QueueUserWorkItem(_ =>
            {
                try
                {
                    // Uzun işlemi simüle etmek için bekliyoruz
                    System.Threading.Thread.Sleep(saniye * 1000);

                    // İşlem tamamlandığında callback'i çağırıyoruz
                    islemTamamlandiCallback(true, "İşlem başarıyla tamamlandı!");
                }
                catch (Exception ex)
                {
                    // Hata durumunda callback'i hata bilgisiyle çağırıyoruz
                    islemTamamlandiCallback(false, $"Hata oluştu: {ex.Message}");
                }
            });
        }

        static void IslemTamamlandi(bool basarili, string mesaj)
        {
            if (basarili)
            {
                Console.WriteLine($"CALLBACK: {mesaj}");
            }
            else
            {
                Console.WriteLine($"CALLBACK HATA: {mesaj}");
            }
        }

        // Örnek 3 için filtreleme metotları
        static bool PahaliUrunler(Urun urun)
        {
            return urun.Fiyat > 7000;
        }

        static bool StokAzUrunler(Urun urun)
        {
            return urun.Stok < 10;
        }

        static List<Urun> FiltreleUrunler(List<Urun> urunler, FiltreDelegate<Urun> filtre)
        {
            List<Urun> sonuc = new List<Urun>();

            foreach (var urun in urunler)
            {
                if (filtre(urun))
                {
                    sonuc.Add(urun);
                }
            }

            return sonuc;
        }

        static void UrunleriGoster(List<Urun> urunler)
        {
            foreach (var urun in urunler)
            {
                Console.WriteLine($"- {urun.Ad}, {urun.Fiyat} TL, Stok: {urun.Stok}");
            }
        }

        // Örnek 4 için dönüştürme metotları
        static int StringiSayiyaDonustur(string metin)
        {
            int.TryParse(metin, out int sonuc);
            return sonuc;
        }

        static string SayiyiStringeDonustur(int sayi)
        {
            return sayi.ToString();
        }

        static string BuyukHarfeDonustur(string metin)
        {
            return metin.ToUpper();
        }

        static List<TOutput> ListeyiDonustur<TInput, TOutput>(
            List<TInput> liste,
            DonusturuDelegate<TInput, TOutput> donusturucu)
        {
            List<TOutput> sonuc = new List<TOutput>();

            foreach (var item in liste)
            {
                sonuc.Add(donusturucu(item));
            }

            return sonuc;
        }

        // Örnek 5 için metin işleme metotları
        static string BosluklariKaldir(string metin)
        {
            return metin.Replace(" ", "");
        }

        static string TireleBirlestir(string metin)
        {
            char[] karakterler = metin.ToCharArray();
            return string.Join("-", karakterler);
        }
    }

    // Örnek 1 için event argümanları sınıfı
    public class VeriDegistiEventArgs : EventArgs
    {
        public string EskiVeri { get; }
        public string YeniVeri { get; }

        public VeriDegistiEventArgs(string eskiVeri, string yeniVeri)
        {
            EskiVeri = eskiVeri;
            YeniVeri = yeniVeri;
        }
    }

    // Örnek 1 için olay sahibi sınıf
    public class VeriDeposu
    {
        private string _veri;

        // Event tanımı
        public event VeriDegistiEventHandler VeriDegisti;

        // Veri özelliği, değiştiğinde olayı tetikler
        public string Veri
        {
            get { return _veri; }
            set
            {
                // Değer gerçekten değiştiyse olayı tetikle
                if (_veri != value)
                {
                    string eskiVeri = _veri;
                    _veri = value;

                    // Olay abonesi varsa olayı tetikle
                    VeriDegisti?.Invoke(this, new VeriDegistiEventArgs(eskiVeri, _veri));
                }
            }
        }
    }

    // Örnek 3 için Ürün sınıfı
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public string Kategori { get; internal set; }
    }

    #endregion
    
    #region Action ve Func delegeler, lambda expression

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Delegeleri - Func, Action ve Lambda Expressions\n");

            // ÖRNEK 1: Action Delegate Kullanımı
            // ============================
            Console.WriteLine("### ÖRNEK 1: Action Delegate Kullanımı ###");

            // Action: Parametre alabilen ve geriye değer döndürmeyen metotları temsil eder
            // Action<T1, T2, ...> şeklinde tanımlanır ve en fazla 16 parametre alabilir

            // Parametresiz Action tanımı
            Action selamVer = SelamlamaYazdir;

            // Tek parametreli Action tanımı
            Action<string> mesajGoster = MesajYazdir;

            // İki parametreli Action tanımı
            Action<string, int> tekrarliMesaj = TekrarliMesajYazdir;

            // Action delegelerini çağırma
            selamVer();
            mesajGoster("Merhaba Action delegate dünyası!");
            tekrarliMesaj("Bu mesaj tekrarlanacak", 3);

            Console.WriteLine();


            // ÖRNEK 2: Func Delegate Kullanımı
            // ============================
            Console.WriteLine("### ÖRNEK 2: Func Delegate Kullanımı ###");

            // Func: Parametre alabilen ve geriye değer döndüren metotları temsil eder
            // Func<T1, T2, ..., TResult> şeklinde tanımlanır ve son generic parametre dönüş tipidir

            // İki parametre alıp geriye int döndüren Func delegesi
            Func<int, int, int> toplama = Topla;
            Func<int, int, int> cikarma = Cikar;
            Func<int, int, int> carpma = Carp;

            // Func delegelerini çağırma
            Console.WriteLine($"Toplama: 10 + 5 = {toplama(10, 5)}");
            Console.WriteLine($"Çıkarma: 20 - 8 = {cikarma(20, 8)}");
            Console.WriteLine($"Çarpma: 7 * 6 = {carpma(7, 6)}");

            // Tek parametre alıp geriye string döndüren Func delegesi
            Func<int, string> sayiDonustur = SayiyiYaziyla;
            Console.WriteLine($"Sayı dönüşüm: 5 -> {sayiDonustur(5)}");

            // Parametre almayan ama geriye değer döndüren Func delegesi
            Func<DateTime> tarihGetir = SimdikiTarih;
            Console.WriteLine($"Şimdiki tarih: {tarihGetir()}");

            Console.WriteLine();


            // ÖRNEK 3: Lambda Expressions ile Delegeler
            // ============================
            Console.WriteLine("### ÖRNEK 3: Lambda Expressions ile Delegeler ###");

            // Lambda sözdizimi: 
            // (parametreler) => ifade veya { ifadeler; }

            // Lambda ile Action tanımlama
            Action<string> ekranaYaz = (mesaj) => Console.WriteLine($"Lambda: {mesaj}");
            ekranaYaz("Merhaba Lambda dünyası!");

            // Lambda ile Func tanımlama
            Func<int, int, int> bolme = (a, b) => b != 0 ? a / b : 0;
            Console.WriteLine($"Bölme: 20 / 4 = {bolme(20, 4)}");
            Console.WriteLine($"Bölme (sıfıra bölme kontrolü): 10 / 0 = {bolme(10, 0)}");

            // Çoklu ifade içeren Lambda
            Func<int, string> ciftTekKontrol = (x) => {
                if (x % 2 == 0)
                    return $"{x} çift bir sayıdır.";
                else
                    return $"{x} tek bir sayıdır.";
            };

            Console.WriteLine(ciftTekKontrol(7));
            Console.WriteLine(ciftTekKontrol(8));

            Console.WriteLine();



            // ÖRNEK 4: Predicate Delegate Kullanımı (Func<T, bool> ile aynıdır)
            // ============================
            Console.WriteLine("### ÖRNEK 4: Predicate Delegate Kullanımı ###");

            // Predicate<T> delegate'i aslında Func<T, bool> ile aynıdır
            // Bir nesneyi alır ve geriye bool döndürür

            // Liste oluşturma
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Predicate tanımlama
            Predicate<int> ciftSayiMi = sayi => sayi % 2 == 0;

            // Liste üzerinde Predicate kullanma
            List<int> ciftSayilar = sayilar.FindAll(ciftSayiMi);

            Console.Write("Çift sayılar: ");
            foreach (int sayi in ciftSayilar)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            // Lambda ile doğrudan kullanım
            List<int> tekSayilar = sayilar.FindAll(sayi => sayi % 2 != 0);

            Console.Write("Tek sayılar: ");
            foreach (int sayi in tekSayilar)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();


            // LINQ, Lambda ifadelerini yoğun şekilde kullanır
            // Ürünler listesi oluşturalım
            var urunler = new List<Urun>
            {
                new Urun { Id = 1, Ad = "Laptop", Fiyat = 15000, Kategori = "Elektronik" },
                new Urun { Id = 2, Ad = "Telefon", Fiyat = 8000, Kategori = "Elektronik" },
                new Urun { Id = 3, Ad = "Masa", Fiyat = 2000, Kategori = "Mobilya" },
                new Urun { Id = 4, Ad = "Sandalye", Fiyat = 500, Kategori = "Mobilya" },
                new Urun { Id = 5, Ad = "Kitaplık", Fiyat = 1500, Kategori = "Mobilya" },
                new Urun { Id = 6, Ad = "Tablet", Fiyat = 5000, Kategori = "Elektronik" }
            };

            // Where metodu bir Func<T, bool> delegesi alır
            var pahaliUrunler = urunler.Where(u => u.Fiyat > 5000).ToList();

            Console.WriteLine("5000 TL'den pahalı ürünler:");
            pahaliUrunler.ForEach(u => Console.WriteLine($"- {u.Ad}, {u.Fiyat} TL"));

            // Kategoriye göre gruplama
            var kategoriGruplari = urunler.GroupBy(u => u.Kategori);

            Console.WriteLine("\nKategorilere göre ürünler:");
            foreach (var grup in kategoriGruplari)
            {
                Console.WriteLine($"{grup.Key} Kategorisi:");
                foreach (var urun in grup)
                {
                    Console.WriteLine($"  - {urun.Ad}, {urun.Fiyat} TL");
                }
            }



            // Select ile dönüşüm
            var urunAdlari = urunler.Select(u => u.Ad).ToList();

            Console.WriteLine("\nSadece ürün adları:");
            urunAdlari.ForEach(ad => Console.Write($"{ad}, "));
            Console.WriteLine();


            // ÖRNEK 6: Event Pattern'de Func ve Action kullanımı
            // ============================
            Console.WriteLine("### ÖRNEK 6: Event Pattern'de Func ve Action kullanımı ###");

            // EventHandler<T> yerine Action<T> kullanabiliriz
            var veriIsleyici = new VeriIsleyici();

            // Action<T> ile olaya abone olma
            veriIsleyici.VeriIslendiginde += (veri) => {
                Console.WriteLine($"Veri işlendi: {veri}");
            };

            // Lambda ile Func kullanımı - işlemin yapılıp yapılmayacağını belirler
            veriIsleyici.VeriDogrulayici = (veri) => {
                // Sadece sayısal değerleri kabul edelim
                bool sayisalMi = veri.All(c => char.IsDigit(c));
                if (!sayisalMi)
                    Console.WriteLine("Hata: Sadece sayısal değerler kabul edilir!");
                return sayisalMi;
            };

            // Veri işleme metotlarını çağıralım
            veriIsleyici.VeriIsle("12345"); // Geçerli veri
            veriIsleyici.VeriIsle("ABC123"); // Geçersiz veri

            Console.WriteLine();

            // ÖRNEK 7: Higher-Order Functions (Üst Düzey Fonksiyonlar)
            // ============================
            Console.WriteLine("### ÖRNEK 7: Higher-Order Functions ###");

            // Delegate döndüren metotlar (higher-order functions)
            Func<int, int> kareBul = SayininKuvvetiniAlFonksiyonuUret(2);
            Func<int, int> kupBul = SayininKuvvetiniAlFonksiyonuUret(3);

            Console.WriteLine($"5'in karesi: {kareBul(5)}");
            Console.WriteLine($"4'ün küpü: {kupBul(4)}");

            // Delegate kabul eden ve döndüren metot
            Func<int, int> ikiKati = x => x * 2;
            Func<int, int> ikiKatininKaresi = FonksiyonlariZincirle(ikiKati, kareBul);

            Console.WriteLine($"7'nin iki katının karesi: {ikiKatininKaresi(7)}"); // (7*2)^2 = 196

            Console.WriteLine();

            // ÖRNEK 8: Lambda Capture (Lambda Değişken Yakalama)
            // ============================
            Console.WriteLine("### ÖRNEK 8: Lambda Capture (Değişken Yakalama) ###");

            // Lambda ifadeleri dışarıdaki değişkenleri "yakalayabilir" (capture)
            int carpan = 10;

            Func<int, int> carpmaIslemiFonksiyonu = x => x * carpan;

            Console.WriteLine($"5 x {carpan} = {carpmaIslemiFonksiyonu(5)}");

            // Yakalanan değişkeni değiştirelim
            carpan = 20;

            // Lambda içindeki değer de değişir (referans ile yakalanır)
            Console.WriteLine($"5 x {carpan} = {carpmaIslemiFonksiyonu(5)}");

            // Lambda içinde lokale değer değiştirme
            Action sayac = () => {
                int sayacDegeri = 0;
                Console.WriteLine($"Sayaç: {++sayacDegeri}");
            };

            sayac(); // Her çağrıda sıfırdan başlar
            sayac(); // Yine 1 yazar çünkü lokale değerler yakalanmaz

            // Doğru yakalama için dışarıda tanımlayalım
            int disSayac = 0;
            Action dogruSayac = () => {
                Console.WriteLine($"Doğru sayaç: {++disSayac}");
            };

            dogruSayac(); // 1
            dogruSayac(); // 2

            Console.WriteLine();

            // ÖRNEK 10: Expression Trees (İfade Ağaçları) ve Lambdalar
            // ============================
            Console.WriteLine("### ÖRNEK 10: Expression Trees ve Lambdalar ###");

            // Func<> tipindeki bir lambda
            Func<int, bool> regularLambda = x => x > 10;

            // Expression<Func<>> tipindeki bir lambda (expression tree)
            System.Linq.Expressions.Expression<Func<int, bool>> expressionLambda = x => x > 10;

            Console.WriteLine("Regular Lambda Sonucu: " + regularLambda(15));
            Console.WriteLine("Expression Tree Yapısı: " + expressionLambda.ToString());

            // Expression tree'yi derleyerek çalıştırılabilir kod elde edelim
            var compiledExpression = expressionLambda.Compile();
            Console.WriteLine("Compiled Expression Sonucu: " + compiledExpression(15));

            Console.ReadKey();
            
        }
        // ÖRNEK METOTlar - Action için
        static void SelamlamaYazdir()
        {
            Console.WriteLine("Merhaba, Action delegate dünyası!");
        }

        static void MesajYazdir(string mesaj)
        {
            Console.WriteLine($"MESAJ: {mesaj}");
        }

        static void TekrarliMesajYazdir(string mesaj, int tekrarSayisi)
        {
            for (int i = 0; i < tekrarSayisi; i++)
            {
                Console.WriteLine($"{i + 1}. {mesaj}");
            }
        }

        // ÖRNEK METOTlar - Func için
        static int Topla(int x, int y)
        {
            return x + y;
        }

        static int Cikar(int x, int y)
        {
            return x - y;
        }

        static int Carp(int x, int y)
        {
            return x * y;
        }

        static string SayiyiYaziyla(int sayi)
        {
            string[] sayilar = { "Sıfır", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz", "On" };
            return sayi >= 0 && sayi < sayilar.Length ? sayilar[sayi] : sayi.ToString();
        }

        static DateTime SimdikiTarih()
        {
            return DateTime.Now;
        }

        // ÖRNEK 7 için - Higher-Order Functions
        static Func<int, int> SayininKuvvetiniAlFonksiyonuUret(int kuvvet)
        {
            // Bir delegate döndüren metot
            return x => (int)Math.Pow(x, kuvvet);
        }

        static Func<int, int> FonksiyonlariZincirle(Func<int, int> ilkFonksiyon, Func<int, int> ikinciFonksiyon)
        {
            // İki fonksiyonu birleştiren ve yeni bir fonksiyon üreten metot
            return x => ikinciFonksiyon(ilkFonksiyon(x));
        }
    }

    // Örnek 5 için Ürün sınıfı


    // Örnek 6 için VeriIsleyici sınıfı
    public class VeriIsleyici
    {
        // Action<T> tipinde bir event tanımlama
        public event Action<string> VeriIslendiginde;

        // Func<T, bool> tipinde bir özellik (veri doğrulama)
        public Func<string, bool> VeriDogrulayici { get; set; } = (veri) => true;

        public void VeriIsle(string veri)
        {
            // Veriyi doğrula
            if (VeriDogrulayici(veri))
            {
                // Veriyi işle
                string islenmisveri = veri.ToUpper();

                // Event'i tetikle
                VeriIslendiginde?.Invoke(islenmisveri);
            }
        }
    }



    #endregion

}
