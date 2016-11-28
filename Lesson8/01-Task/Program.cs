using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Task
{
    class Program
    {
        static int a = 0;
        static int b = 0;

        static void Main(string[] args)
        {
            ReadValues();
            //ActionWithThread();
            ActionWithTask();

            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            return a + b;
        }

        private static void ReadValues()
        {
            Console.Write(" Input a > ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input b > ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        
        static void ActionWithThread()
        {
            Thread thread = new Thread(() => {
                Console.WriteLine(Add(a, b));
            });
            thread.Start();
        }

        static void ActionWithTask()
        {
            Task<int> task = Task.Run(() => Add(a, b));
            Console.WriteLine($" Result: {task.Result}");
        }
    }
}
