using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GarbageCollectorInfo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine($"Occupied memory at the start (byte): {GC.GetTotalMemory(false)}");
          
            GarbageHelper hlp = new GarbageHelper();
            Console.WriteLine($"GarbageHelper object generation: {GC.GetGeneration(hlp)}");
            Console.WriteLine($"Occupied memory (byte): {GC.GetTotalMemory(false)}");

            hlp.MakeGarbage();
            Console.WriteLine($"Occupied memory (byte): {GC.GetTotalMemory(false)} after MakeGarbage");

            GC.Collect(0);
            Console.WriteLine($"Occupied memory (byte): {GC.GetTotalMemory(false)} after GC.Collect(0)");
            Console.WriteLine($"GarbageHelper object generation: {GC.GetGeneration(hlp)}");

            GC.Collect();
            Console.WriteLine($"GarbageHelper object generation: {GC.GetGeneration(hlp)} after GC.Collect()");
            Console.WriteLine($"Occupied memory (byte): {GC.GetTotalMemory(false)}");

            Console.ReadKey();
        }

    }
}
