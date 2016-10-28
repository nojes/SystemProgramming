using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Timer
{
    class Program
    {
        private static int sec = 10;

        static void Main(string[] args)
        {
            TimerCallback timerCallback = new TimerCallback(TimerTick);
            Timer timer = new Timer(timerCallback);

            Console.WriteLine("Timer start.");
            timer.Change(1000, 1000);

            Console.ReadKey();
        }

        private static void TimerTick(object state)
        {
            sec--;
            Console.WriteLine(sec.ToString());

            if (sec > 0) return;

            Timer t = (Timer)state;
            t.Dispose();
            Console.WriteLine("Timer stoped.");
        }
    }
}
