using System;
using System.Threading;

namespace _01_ObjectLog
{
    public class Log
    {
        public Thread Thread;
        private string propertyName;
        private string filePath;
        object lockObj = new object();

        public Log(string propertyName, string filePath)
        {
            this.propertyName = propertyName;
            this.filePath = filePath;
            Thread = new Thread(Run);
            Thread.Start();
        }

        private void Run()
        {
            lock (lockObj) {
                Console.ForegroundColor = ConsoleColor.Green;
                LogWriter logWriter = LogWriter.GetLog(filePath);

                string nowTime = Convert.ToString(DateTime.Now);
                logWriter.StreamWriter.WriteLine($"[{nowTime}]: Changed property: {propertyName}");
                logWriter.StreamWriter.Flush();
                Console.WriteLine($"[{nowTime}]: Changed property: {propertyName}");
                Thread.Sleep(500);

                Console.ResetColor();
            }
        }
    }
}