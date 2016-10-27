using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_FileSearch
{
    class Program
    {
        static void Main(string[] args)
        {
//            Search();
            Console.ReadLine();
            Thread thread = new Thread(Search);

            thread.Start();

            Console.Read();
        }

        static void Search()
        {
            string ext = "*.";

            Console.Write(" Input file extension > ");
            ext += Console.ReadLine();

            var root = new DirectoryInfo("D:/Nozhenko");
            DirectoryInfo[] directories = root.GetDirectories();

            Console.WriteLine();
            foreach (DirectoryInfo directory in directories) {
                FileInfo[] files = directory.GetFiles(ext);

                if (files.Length != 0) {
                    foreach (var file in files) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"/{directory.Name}/{file.Name}");
                        Console.ResetColor();
                    }  
                } else {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"/{directory.Name}/ {ext} not found.");
                    Console.ResetColor();
                }
            }

            Console.Read();
        }
    }
}
