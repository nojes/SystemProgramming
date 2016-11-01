using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_AsyncOperations
{
    class Program
    {
        private delegate ulong AsyncSumDelegate(ulong n);

        static void Main(string[] args)
        {
            AsyncSumDelegate asyncDelegate = Sum;

            ulong res = asyncDelegate.Invoke(1000000);

            IAsyncResult asyncResult = asyncDelegate.BeginInvoke(1000000, Method, null);

            Console.WriteLine(MethodBase.GetCurrentMethod());
            Console.WriteLine(res);

            Console.ReadKey();
        }

        private static ulong Sum(ulong n)
        {
            ulong sum = 0;
            for (ulong i = 0; i < n; i++) {
                sum += i;
            }
            Thread.Sleep(3000);
            return sum;
        }

        static void Method(IAsyncResult iAsyncResult)
        {
            Console.WriteLine($"Invoke Thread {Thread.CurrentThread.ManagedThreadId}");
            AsyncResult asyncResult = (AsyncResult)iAsyncResult;
            AsyncSumDelegate sumDelegate = (AsyncSumDelegate) asyncResult.AsyncDelegate;
            Console.WriteLine($"Result: {sumDelegate.EndInvoke(iAsyncResult)}");
        }
    }
}
