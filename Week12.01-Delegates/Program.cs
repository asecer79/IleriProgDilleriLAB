

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


public class Program
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

public class Program2
{
    // Olaya dönüştürülebilen delegate tanımı
    // Konvansiyonel olarak 'EventHandler' şeklinde adlandırılır
    public delegate void VeriDegistiEventHandler(object sender, VeriDegistiEventArgs e);

    // Koşullu filtreleme için kullanılacak delegate
    public delegate bool FiltreDelegate<T>(T item);


    // Genericleştirilmiş delegate tanımı - Action/Func kullanmadan
    public delegate TOutput DonusturuDelegate<TInput, TOutput>(TInput input);


    static void Main(string[] args)
    {
        
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

#endregion

