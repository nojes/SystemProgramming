using System;
using System.Threading;

namespace _02_ThreadPool
{
    public class ThreadHelper
    {
        public static void ShowThreadsInfo()
        {
            int availableWorkThreads, availableIOThreads, maxWorkThreads, maxIOThreads;
            ThreadPool.GetAvailableThreads(out availableWorkThreads, out availableIOThreads);
            ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);
            Console.WriteLine($"Working threads: {availableWorkThreads} of {maxWorkThreads}");
            Console.WriteLine($"Working IO threads: {availableIOThreads} of {maxIOThreads}");
        }
    }
}