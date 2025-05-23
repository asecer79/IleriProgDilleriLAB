namespace Week14_01_TPL
{

    class Program
    {
        static async Task Main(string[] args)
        {

            //Task task1 = new Task(async () =>
            //{
            //    Console.WriteLine("Task 1 is running...");
            //    Task.Delay(5000);
            //    Console.WriteLine("Task 1 completed.");
            //});

            //Task task2 = new Task(() =>
            //{
            //    Console.WriteLine("Task 2 is running...");
            //    Task.Delay(1000);
            //    Console.WriteLine("Task 2 completed.");
            //});
            //task1.Start();
            //task2.Start();

            //Task.WaitAll(task1,task2);

            //task1.Wait();
            //task2.Wait();


            //var cts = new CancellationTokenSource();
            //var token = cts.Token;

            //Task t = Task.Run(() =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        if (token.IsCancellationRequested)
            //        {
            //            Console.WriteLine("İptal edildi.");
            //            return;
            //        }
            //        Console.WriteLine(i);
            //    }
            //}, token);

            //Thread.Sleep(10);
            //cts.Cancel();


            //Task t1 = Task.Run(() =>
            //{
            //    Console.WriteLine("1");
            //    Thread.Sleep(500);
            //});
            //Task t2 = Task.Run(() =>
            //{
            //    Console.WriteLine("2");
            //    Thread.Sleep(1000);
            //});
            //// Task.WaitAll(t1, t2); // bloklar
            ////Task.WhenAll(t1, t2); // bloklar

            //await Task.WhenAny(t1, t2); // t1 bitince döner

          

            //Parallel.Invoke(
            //    () => Console.WriteLine("Görev 1"),
            //                 () => Console.WriteLine("Görev 2")
            //);

            //Parallel.For(0, 5, i =>
            //{
            //    Console.WriteLine($"i: {i} Thread: {Thread.CurrentThread.ManagedThreadId}");
            //});

            //var list = new[] { "A", "B", "C" };
            //Parallel.ForEach(list, item =>
            //{
            //    Console.WriteLine($"Item: {item}, Thread: {Thread.CurrentThread.ManagedThreadId}");
            //});


            //Task t = Task.Run(() => Console.WriteLine("İlk görev"));
            //t.ContinueWith(_ => Console.WriteLine("Devam görevi"));


            //Console.WriteLine("Main Finished");

        }
    }
}

