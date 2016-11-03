using System.Threading;

namespace _01_Counter
{
    public class Counter
    {
        private int count;
        private int maxCount;

        private Mutex mutex;

        public int Count => count;

        public int MaxCount {
            get { return maxCount; }
            set { maxCount = value; }
        }

        public Counter()
        {
            maxCount = 1000000;
            mutex = new Mutex(false, "SYNC_MUTEX");
        }

        public Counter(int maxCount)
        {
            this.maxCount = maxCount;
        }

        public void UpdateFields()
        {
            for (int i = 0; i < maxCount; i++) {
                mutex.WaitOne();
                ++count;
                mutex.ReleaseMutex();
            }
        }

        public override string ToString()
        {
            return $" Count: {count}";
        }
    }
}