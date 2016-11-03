using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_MutexOneProcess
{
    class Program
    {
        static Mutex m;
        static string mutexName = "TEST_MUTEX";

        static void Main(string[] args)
        {
            
            try {
                m = Mutex.OpenExisting(mutexName);
            }
            catch (Exception ex) {
                ConsoleHelper.WriteError(ex.Message);
            }

            if (m != null) {
                ConsoleHelper.WriteError("App is already running!");
                Console.ReadKey();
            }

            using (m = new Mutex(true, mutexName)) {
                ConsoleHelper.WriteSuccess("App is successfully running.");
                Console.WriteLine("\n Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
