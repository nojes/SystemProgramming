using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_ObjectLog
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(Person.filePath)) {
                File.Create(Person.filePath);
                Thread.Sleep(500);
            }
            var person = new Person() {
                FirstName = "Vasya",
                LastName = "Pupkin",
                Birthday = new DateTime(1990, 05, 23)
            };

            Console.ReadKey();
        }
    }
}
