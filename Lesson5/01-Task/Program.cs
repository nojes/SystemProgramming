using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int lenght = 50000;
                Console.Write("Input lenght > ");

                lenght = Convert.ToInt32(Console.ReadLine());

                var task1 = new Task(Calc, lenght);
                task1.Start();
            }
            catch (Exception ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
           
            // Delay.
            Console.ReadKey();
        }

        static void Calc(object length)
        {
            for (int i = 0; i < (int)length; i++) {
                if (i % 21 == 0 && i % 99 == 0) {
                    Console.WriteLine($"{i}\t");
                }
            }
        }
    }
}
