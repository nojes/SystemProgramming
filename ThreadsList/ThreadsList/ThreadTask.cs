using System.Threading;

namespace ThreadsList
{
    public class ThreadTask
    {
        private int count;
        private int Number { get; set; }

        public override string ToString()
        {
            return $"Thread '{Number}' -> {count}";
        }

        public void Run(object obj)
        {
            Semaphore s = obj as Semaphore;
            s.WaitOne(1000);

            ++count;
        }
    }
}