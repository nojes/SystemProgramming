using System;
using System.Threading;

namespace _02_ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadHelper.ShowThreadsInfo();

            Console.ReadKey();
        }
    }
}
