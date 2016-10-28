using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_ThreadSuspend
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable 618

            MyThread thread = new MyThread();

            Thread.Sleep(3000);
            thread.Thread.Suspend();

            ConsoleHelper.Print("2", 50, 100, ConsoleColor.Red);

            thread.Thread.Resume();

#pragma warning restore 618
        }
    }
}
