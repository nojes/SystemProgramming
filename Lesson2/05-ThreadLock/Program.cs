using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_ThreadLock
{
    class Program
    {
        private static object lockObj = new object();
        private static ReaderWriterLockSlim _readerWriter = new ReaderWriterLockSlim();

        private static string fileName;

        static void Main(string[] args)
        {
            fileName = "data.dat";
            if (!File.Exists(fileName)) {
                File.Create(fileName);
            }

            Thread.Sleep(2000);
            var thread1 = new Thread(new ThreadStart(Run1));
            var thread2 = new Thread(new ThreadStart(Run2));

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }

        static void Run1()
        {
            for (int i = 0; i < 100; i++) {
                if (i % 2 == 1) {
                    lock (lockObj) {
                        _readerWriter.EnterWriteLock();
                        using (var streamWriter = new StreamWriter(fileName, true)) {
                            streamWriter.WriteLine(i);
                            streamWriter.Close();
                        }
                        _readerWriter.ExitWriteLock();
                        Console.WriteLine($"{Thread.CurrentThread.GetHashCode()} | {i}");
                    }
                }
                Thread.Sleep(100);
            }
        }

        static void Run2()
        {
            for (int i = 0; i < 100; i++) {
                if (i % 2 == 0) {
                    lock (lockObj) {
                        _readerWriter.EnterWriteLock();
                        using (var streamWriter = new StreamWriter(fileName, true)) {
                            streamWriter.WriteLine(i);
                            streamWriter.Close();
                        }
                        _readerWriter.ExitWriteLock();
                        Console.WriteLine($"{Thread.CurrentThread.GetHashCode()} | {i}");
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
