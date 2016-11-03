using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Mutex
{
    class Program
    {
        static readonly Mutex mutex = new Mutex(false, "MUTEX_SAMPLE");

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];

            for (int i = 0; i < threads.Length; i++) {
                threads[i] = new Thread(new ThreadStart(ThreadStatus)) {
                    Name = i.ToString()
                };
                threads[i].Start();
            }
        }

        private static void ThreadStatus()
        {
            bool isMutex = mutex.WaitOne();

            Console.WriteLine($"[{DateTime.Now.TimeOfDay}]: Thread {Thread.CurrentThread.Name} started.");
            Thread.Sleep(2000);
            Console.WriteLine($"[{DateTime.Now.TimeOfDay}]: Thread {Thread.CurrentThread.Name} stoped.");

            mutex.ReleaseMutex();
        }
    }
}
