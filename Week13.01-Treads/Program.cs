namespace Week13._01_Treads
{

    //Paralel işleme.
    /*
    class Program
    {
        
        static void Main(string[] args)
        {
            //Main Tread starts

            Console.WriteLine("Ana iş parçacığı başladı. 1");

            //Thread oluşturma
            Thread thread1 = new Thread(PrintNumbers);
            //PrintNumbers();



            //Thread oluşturma
            Thread thread2 = new Thread(PrintLetters);
            //PrintLetters();


            Console.WriteLine($"{thread1.ManagedThreadId} başladı 2");
            thread1.Start();

            Console.WriteLine($"{thread2.ManagedThreadId} başladı 3");
            thread2.Start();


            Console.WriteLine("Ana iş parçacığı devam ediyor. 4");
            Console.ReadLine();


            //main thread ends
            Console.WriteLine("Ana iş parçacığı bitti. Tüm alt iş parçacıkları bitti 5");
        }


        static void PrintNumbers()
        {

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Sayı: {i}");
                Thread.Sleep(500); // Her adımda 0.5 saniye bekle
            }
        }

        static void PrintLetters()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Harf: {c}");
                Thread.Sleep(500); // Her adımda 0.5 saniye bekle
            }
        }
    }

    */


    //Join metodu, bir iş parçacığının tamamlanmasını beklemek için kullanılır.
    /*
    class Program
    {
        static void Main()
        {
            Thread t1 = new Thread(PrintNumbers);
            Thread t2 = new Thread(PrintLetters);

            t1.Start();
            t1.Join(); // t1 bitene kadar bekle

            t2.Start();
            t2.Join(100); // t2 bitene kadar bekle

            Console.WriteLine("Main thread işlemleri tamamladı.");
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Sayı: {i}");
                Thread.Sleep(500);
            }
        }

        static void PrintLetters()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Harf: {c}");
                Thread.Sleep(500);
            }
        }
    }

    */


    //Background ve Foreground iş parçacıkları

    /*
    class Program
    {
        static void Main()
        {
            Thread t1 = new Thread(PrintNumbers);
            Thread t2 = new Thread(PrintLetters);
            t1.IsBackground = true; // Arka plan iş parçacığı
            t2.IsBackground = true; // Ön plan iş parçacığı
            t1.Start();
            t2.Start();
            Console.WriteLine("Main thread işlemleri tamamladı.");
        }
        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Sayı: {i}");
                Thread.Sleep(1000);
            }
        }
        static void PrintLetters()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Harf: {c}");
                Thread.Sleep(500);
            }
        }
    }

    */

    //Thread sınıfı ve ThreadPool sınıfı arasındaki farklar
    /*
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.SetMinThreads(20, 5);
            ThreadPool.SetMaxThreads(20, 5);


            for (int i = 1; i <= 1000; i++)
            {
                ThreadPool.QueueUserWorkItem(PrintNumbers, i);
            }


            Console.ReadLine();
        }

        static void PrintNumbers(object op)
        {
            Console.WriteLine($"Job: {op}");
            Thread.Sleep(new Random().Next(1000,2000));

        }
    }
    */


    //Thread synchronization ve concurrency

    //thread safe class with lock
    public class BankAccount
    {
        public int Balance = 1000;

        //lock anahtar kelimesi, bir iş parçacığının belirli bir kod bloğunu çalıştırırken diğer iş parçacıklarının o kod bloğuna erişimini engeller.
        private readonly object _lock = new object();

        public void Deposit(int amount)
        {
            lock (_lock)
            {
                int temp = Balance;
                Thread.Sleep(1); // işlem gecikmesi simülasyonu
                temp += amount;
                Balance = temp;
                Console.WriteLine(Balance);
            }
        }

        public void Withdraw(int amount)
        {
            lock (_lock)
            {
                int temp = Balance;
                Thread.Sleep(1); // işlem gecikmesi simülasyonu
                temp -= amount;
                Balance = temp;
                Console.WriteLine(Balance);
            }
        }
    }


    //thread safe class with Mutex
    public class BankAccountMutex
    {
        public int Balance = 1000;

        //bir iş parçacığının belirli bir kod bloğunu çalıştırırken diğer iş parçacıklarının o kod bloğuna erişimini engeller.
        private readonly Mutex _mutex = new Mutex();

        public void Deposit(int amount)
        {
            _mutex.WaitOne();
            int temp = Balance;
            Thread.Sleep(1); // işlem gecikmesi simülasyonu
            temp += amount;
            Balance = temp;
            Console.WriteLine(Balance);
            _mutex.ReleaseMutex();

        }

        public void Withdraw(int amount)
        {
            _mutex.WaitOne();

            int temp = Balance;
            Thread.Sleep(1); // işlem gecikmesi simülasyonu
            temp -= amount;
            Balance = temp;
            Console.WriteLine(Balance);

            _mutex.ReleaseMutex();

        }
    }

    public class BankAccountSemaphore
    {
        public int Balance = 1000;

        //bir iş parçacığının belirli bir kod bloğunu çalıştırırken diğer iş parçacıklarının o kod bloğuna erişimini engeller.
        private readonly Semaphore _semaphore = new Semaphore(1, 1);

        public void Deposit(int amount)
        {
            _semaphore.WaitOne();
            int temp = Balance;
            Thread.Sleep(1); // işlem gecikmesi simülasyonu
            temp += amount;
            Balance = temp;
            Console.WriteLine(Balance);
            _semaphore.Release();

        }

        public void Withdraw(int amount)
        {
            _semaphore.WaitOne();

            int temp = Balance;
            Thread.Sleep(1); // işlem gecikmesi simülasyonu
            temp -= amount;
            Balance = temp;
            Console.WriteLine(Balance);

            _semaphore.Release();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sonucu görmek için enter a basınız");


            //BankAccount account = new BankAccount(); //with lock
            //BankAccountMutex account = new BankAccountMutex();  //with mutex
            BankAccountSemaphore account = new BankAccountSemaphore();  //with semaphore



            Console.WriteLine("Initial Balance: " + account.Balance);


            //Thread t1 = new Thread(() => account.Deposit(100));
            //Thread t2 = new Thread(() => account.Deposit(100));
            //Thread t3 = new Thread(() => account.Deposit(100));
            //Thread t4 = new Thread(() => account.Deposit(100));
            //Thread t5 = new Thread(() => account.Withdraw(100));
            //Thread t6 = new Thread(() => account.Withdraw(100));
            //Thread t7 = new Thread(() => account.Withdraw(100));
            //Thread t8 = new Thread(() => account.Withdraw(100));

            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();
            //t6.Start();
            //t7.Start();
            //t8.Start();


            /* Thread t1 = new Thread(() =>
                 {
                     for (int i = 1; i <= 10; i++)
                     {
                         account.Deposit(100);
                     }
                 });

             Thread t2 = new Thread(() =>
             {
                 for (int i = 1; i <= 10; i++)
                 {
                     account.Withdraw(100);
                 }
             });

             t1.Start();
             t2.Start();

             t1.Join();
             t2.Join();

             Console.WriteLine("Final Balance: " + account.Balance);*/


            //process1 
            using (var mutex = new Mutex(false, @"C:\Files\MySharedMutex"))
            {
                Console.WriteLine("App1: Mutex bekleniyor...");
                mutex.WaitOne();
                Console.WriteLine("App1: Mutex alındı. 5 saniye işlem yapılıyor...");
                Thread.Sleep(5000);
                Console.WriteLine("App1: İşlem bitti, Mutex bırakılıyor.");
                mutex.ReleaseMutex();
            }


            //process2 
            using (var mutex = new Mutex(false, @"C:\Files\MySharedMutex"))
            {
                Console.WriteLine("App2: Mutex bekleniyor...");
                mutex.WaitOne();
                Console.WriteLine("App2: Mutex alındı. 3 saniye işlem yapılıyor...");
                Thread.Sleep(3000);
                Console.WriteLine("App2: İşlem bitti, Mutex bırakılıyor.");
                mutex.ReleaseMutex();
            }


            /*

            bool createdNew;
            Semaphore semaphore = new Semaphore(1, 1, "Global\\MySharedSemaphore", out createdNew);

            Console.WriteLine("App1: Semaphore bekleniyor...");
            semaphore.WaitOne(); // kilidi al
            Console.WriteLine("App1: Semaphore alındı. 5 saniye işlem yapılıyor...");
            Thread.Sleep(5000);
            Console.WriteLine("App1: İşlem tamamlandı. Semaphore serbest bırakılıyor.");
            semaphore.Release(); // kilidi bırak



            bool createdNew;
            Semaphore semaphore = new Semaphore(1, 1, "Global\\MySharedSemaphore", out createdNew);

            Console.WriteLine("App2: Semaphore bekleniyor...");
            semaphore.WaitOne(); // kilidi al
            Console.WriteLine("App2: Semaphore alındı. 3 saniye işlem yapılıyor...");
            Thread.Sleep(3000);
            Console.WriteLine("App2: İşlem tamamlandı. Semaphore serbest bırakılıyor.");
            semaphore.Release(); // kilidi bırak
            */
        }
    }
}
