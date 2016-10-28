using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerCallback timerCallback = new TimerCallback(TimerTick);

            Timer timer = new Timer(timerCallback);
            timer.Change(2000, 500);

            Console.ReadKey();
        }

        static void TimerTick(object o)
        {
            Timer t = o as Timer;

            Console.WriteLine("tick");
        }
    }
}
