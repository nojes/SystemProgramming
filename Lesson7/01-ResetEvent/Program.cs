using System;
using System.Threading;

namespace _01_ResetEvent
{
    class Program
    {
        private static readonly AutoResetEvent AutoReset = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any key ...");

            Thread thread = new Thread(actionColors);
            thread.Start();

            Console.ReadKey();
            AutoReset.Set();

            Console.ReadKey();
            AutoReset.Set();

            Console.ReadKey();
        }

        private static void actionColors()
        {
            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            AutoReset.WaitOne();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow");
            AutoReset.WaitOne();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green");
        }
    }
}
