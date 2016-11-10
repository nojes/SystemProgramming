using System;

namespace _04_IDisposable
{
    public class ResourceWrapper : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        ~ResourceWrapper()
        {
            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Finalise.");
            CleanUp(false);
        }

        private void CleanUp(bool clean)
        {
            if (!this.disposed)
            {
                if (clean)
                {
                    Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Release resources.");
                }
                Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Finalized.");
            }
            this.disposed = true;
        }
    }
}