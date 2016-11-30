using System;
using System.Threading;

namespace ThreadsList
{
    enum ThreadTaskState { Create, Wait, Run, Stop }

    class ThreadTask
    {
        Thread thread;
        int count;
        public int Number { get;  set; }
        Semaphore semaphore;

        public ThreadTaskState State { get; set; }

        public ThreadTask(Semaphore semaphore, int number)
        {
            Number = number;
            this.semaphore = semaphore;
            State = ThreadTaskState.Create;
            thread = new Thread(Run) {IsBackground = true};
        }

        public void Start()
        {
            thread.Start();
        }

        public void Run()
        {
            if (semaphore.WaitOne())
            {
                while (true)
                {
                    if (State == ThreadTaskState.Run)
                    {
                        //Console.WriteLine("Поток {0} блокировку получил, State {1}", Thread.CurrentThread.ManagedThreadId, ThreadTaskState.Run);
                        Thread.Sleep(1000);
                        count++;
                    }
                    else if (State == ThreadTaskState.Wait)
                    {
                        //Console.WriteLine("Поток {0} блокировку получил, State {1}", Thread.CurrentThread.ManagedThreadId, ThreadTaskState.Wait);
                        Thread.Sleep(500);
                        State = ThreadTaskState.Run;
                    }
                    else if (State == ThreadTaskState.Stop)
                    {
                        semaphore.Release();
                        return;
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"Thread # {Number} -> {count}";
        }
    }
}
