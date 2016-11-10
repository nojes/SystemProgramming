using System;

namespace _01_GarbageCollectorException
{
    public class BigArray
    {
        private int[] array;

        public BigArray()
        {
            array = new int[100];
        }

        public BigArray(int length)
        {
            array = new int[length];
        }

        ~BigArray()
        {
            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Object {this.GetHashCode()} was deleted.");
        }

        public int GetValue(int i)
        {
            return array[i];
        }
    }
}