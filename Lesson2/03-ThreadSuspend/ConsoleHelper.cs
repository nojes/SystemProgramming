using System;
using System.Threading;

namespace _03_ThreadSuspend
{
    public static class ConsoleHelper
    {
        public static void Print(string str, int count, int sleepTime, ConsoleColor color)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
                Thread.Sleep(sleepTime);
            }
            Console.ResetColor();
        }
    }
}