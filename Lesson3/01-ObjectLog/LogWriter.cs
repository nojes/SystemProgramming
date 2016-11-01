using System.IO;

namespace _01_ObjectLog
{
    public class LogWriter
    {
        private static LogWriter _logWriter;
        static object lockObj = new object();

        public StreamWriter StreamWriter { get; private set; }

        static LogWriter()
        {
            
        }

        private LogWriter(string filePath)
        {
            StreamWriter = new StreamWriter(filePath, true);
        }

        public static LogWriter GetLog(string filePath)
        {
            if (_logWriter == null) {
                lock (lockObj) {
                    if (_logWriter == null) {
                        _logWriter = new LogWriter(filePath);
                    }
                }
            }

            return _logWriter;
        }

        public void Dispose()
        {
            StreamWriter.Close();
        }
    }
}