using System;
using System.Threading;

namespace _02_ManualResetEvent
{
    class Program
    {
        private static readonly ManualResetEvent ManualReset = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any key ...");

            Thread[] threads = {
                new Thread(Action1),
                new Thread(Action2), 
            };

            foreach (Thread thread in threads) {
                thread.Start();
            }

            Console.ReadKey();
            ManualReset.Set();


            Console.ReadKey();
        }

        private static void Action1()
        {
            Console.WriteLine("Thread 1 is running.");
            ManualReset.WaitOne();
            Console.WriteLine("Thread 1 is stoped.");
        }

        private static void Action2()
        {
            Console.WriteLine("Thread 2 is running.");
            ManualReset.WaitOne();
            Console.WriteLine("Thread 2 is stoped.");
        }
    }
}
