using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GarbageCollectorException
{
    class Program
    {
        static void Main(string[] args)
        {
            BigArray[] bigArrays = new BigArray[1000];

            try
            {
                for (int i = 0; i < bigArrays.Length; i++) {
                    bigArrays[i] = new BigArray(10);
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
