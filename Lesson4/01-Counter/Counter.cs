namespace _01_Counter
{
    public class Counter
    {
        private int count;
        private int maxCount;
        private object lockObj = new object();

        public int Count => count;

        public int MaxCount {
            get { return maxCount; }
            set { maxCount = value; }
        }

        public Counter()
        {
            maxCount = 1000000;
        }

        public Counter(int maxCount)
        {
            this.maxCount = maxCount;
        }

        public void UpdateFields()
        {
            for (int i = 0; i < maxCount; i++) {
                lock(lockObj) {
                    ++count;
                }
            }
        }

        public override string ToString()
        {
            return $" Count: {count}";
        }
    }
}