using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TaskPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency currency = new Currency(new DateTime(2016, 10, 01));
            currency.Run();
            currency.ConsoleWrite();

            Console.ReadKey();
        }
    }
}
