using System;
using System.Threading;

namespace _03_ThreadSuspend
{
    public class MyThread
    {
        public Thread Thread;

        public MyThread()
        {
            Thread = new Thread(new ThreadStart(Run));
            Thread.Start();
        }

        public void Run()
        {
            ConsoleHelper.Print("1", 50, 200, ConsoleColor.Red);
        }
    }
}