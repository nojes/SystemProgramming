using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _05_Timers
{
    class Program
    {
        private static ConsoleColor[] consoleColors = {
            ConsoleColor.Red,
            ConsoleColor.DarkRed, 
            ConsoleColor.Yellow, 
            ConsoleColor.DarkYellow, 
            ConsoleColor.Blue, 
            ConsoleColor.DarkBlue, 
            ConsoleColor.Cyan, 
            ConsoleColor.DarkCyan, 
            ConsoleColor.Green, 
            ConsoleColor.DarkGreen, 
            ConsoleColor.White, 
            ConsoleColor.Gray
        };

        static void Main(string[] args)
        {
            var timer = new Timer {
                Interval = 100
            };
            timer.Elapsed += TimerOnElapsed;

            timer.Start();

            Console.ReadKey();
        }

        private static void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            int colorIndex = new Random().Next(consoleColors.Length);
            Console.ForegroundColor = consoleColors[colorIndex];
            Console.Write(" (-_-) ");
            Console.ResetColor();
        }
    }
}
