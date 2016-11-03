using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int threadsCount = 0;
            Counter c = new Counter();

            Console.Write("Max counter value -> ");
            c.MaxCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Threads count -> ");
            threadsCount = Convert.ToInt32(Console.ReadLine());
            

            Thread[] threads = new Thread[threadsCount];
            for (int i = 0; i < threads.Length; i++) {
                threads[i] = new Thread(c.UpdateFields);
                threads[i].Start();
            }
            foreach (Thread t in threads) {
                t.Join();
            }

            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
