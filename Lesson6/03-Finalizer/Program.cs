using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Finalizer
{
    class ResourceWrapper
    {
        ~ResourceWrapper()
        {
            for (int i = 0; i < 1000; i++) {
                Console.Write(".");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var resource = new ResourceWrapper();
            resource = null;

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
