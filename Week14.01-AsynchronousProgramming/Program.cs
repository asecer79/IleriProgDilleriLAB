
namespace Ns1
{

    class MyClass
    {
        static async Task Main(string[] args)
        {
            try
            {
               await MyMethod("B");
               await MyMethod("A");
               await MyMethod("C");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Thread.Sleep(1500);
            Console.WriteLine("Main Finished");
        }

        static async Task MyMethod(string mn)
        {
            Console.WriteLine(mn+" started");

            for (int i = 1; i <= 10; i++)
            {

                 //Thread.Sleep(100);
                 await Task.Delay(100);
                 Console.WriteLine(mn+" "+ i);
            }


        }




    }
}

