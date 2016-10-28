using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            var singleton3 = Singleton.GetInstance();

            Console.WriteLine($"singleton.HashCode: {singleton.GetHashCode()} \n");
            Console.WriteLine($"singleton2.HashCode: {singleton2.GetHashCode()} \n");
            Console.WriteLine($"singleton3.HashCode: {singleton3.GetHashCode()} \n");

            var guid = Guid.NewGuid();
            Console.WriteLine($"Guid: {guid}");

            Console.ReadKey();
        }
    }
}
