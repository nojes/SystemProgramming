using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var wrapper = new ResourceWrapper()) {
                Console.WriteLine(wrapper);
            }
            Console.WriteLine(new string('-', 30));
            
            var wrapper2 = new ResourceWrapper();
            Console.WriteLine(wrapper2);

            wrapper2.Dispose();
            wrapper2.Dispose();
            wrapper2.Dispose();
            wrapper2.Dispose();

            var wrapper3 = new ResourceWrapper();

            Console.ReadKey();
        }
    }
}
