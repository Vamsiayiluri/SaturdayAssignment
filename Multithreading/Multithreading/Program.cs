
namespace MultiThreading
{
    class MultithreadingExample
    {
        static void Main()
        {
            Thread backgroundThread = new Thread(BackgroundTask);
            backgroundThread.Start();
            Console.WriteLine("Main thread is doing some work...");

        }

        static void BackgroundTask()
        {
            Console.WriteLine("Background thread is doing some work...");

            try
            {
                string input = Console.ReadLine();
                int value = Int32.Parse(input);
                Console.WriteLine(value);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}