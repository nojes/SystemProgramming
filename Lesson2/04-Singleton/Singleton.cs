using System;
using System.Reflection;

namespace _04_Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private static object _lockObj = new object();

        public Singleton()
        {
//            Console.WriteLine("{0}", MethodBase.GetCurrentMethod());
        }

        public static Singleton GetInstance()
        {
            if (_instance == null) {
                lock (_lockObj) {
                    if (_instance == null) {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}