
namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nesne oluşturma.

           // Kitap kitap; //null reference
                
           // Kitap kitap1 = new Kitap(); //default constructor

            var kitap2 = new Kitap(); //default constructor

            var kitap3 = new Kitap("A","B"); //overloaded constructor

            var kitap4 = new Kitap("C", "D",1355); //overloaded constructor

            //obje üzerinden erişilebilen tüm üyelere instance member denir.
            //kitap4.KapakRengi   kopya üye/instance member
            //kitap4.ToplamKitapSayisi(); //Hata!

            //sadece sınıf ismi üzerinden erişilebilen üyelere static member denir.
            //kitap4.ToplamKitapSayisi; Hata!
            //Console.WriteLine(Kitap.toplamKitapSayisi);
            //Kitap.toplamKitapSayisi = 200;
            //Kitap.ToplamKitapSayisi();



            Console.WriteLine(kitap4[1]);

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
