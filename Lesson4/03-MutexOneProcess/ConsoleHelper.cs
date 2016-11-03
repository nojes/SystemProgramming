using System;
using System.Diagnostics.Eventing;

namespace _03_MutexOneProcess
{
    public class ConsoleHelper
    {
        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n {message}");
            Console.ResetColor();
        }

        public static void WriteSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n {message}");
            Console.ResetColor();
        }
    }
}