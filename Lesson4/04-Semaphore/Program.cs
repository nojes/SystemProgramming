using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_Semaphore
{
    class Program
    {
        private static Semaphore pool;

        static void Main(string[] args)
        {
            
            pool = new Semaphore(2, 4, "SEMAPHORE_" + Guid.NewGuid().ToString());

            for (int i = 0; i < 8; i++) {
                Thread thread = new Thread(new ParameterizedThreadStart(Run));
                thread.Start(i);
            }
            Thread.Sleep(2000);
            pool.Release(2);


            Console.ReadKey();
        }

        private static void Run(object number)
        {
            pool.WaitOne();

            Console.WriteLine($" ---> Thread '{number}' took the slot.");
            Thread.Sleep(1000);
            Console.WriteLine($" <--- Thread '{number}' vacated the slot. \n");

            pool.Release();
        }
    }
}
