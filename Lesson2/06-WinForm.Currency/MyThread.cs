using System;
using System.Threading;
using System.Windows.Forms;

namespace _06_WinForm.Currency
{
    public class MyThread
    {
        public Thread thread;

        private ListBox _listBox;

        public MyThread(ListBox listBox)
        {
            this._listBox = listBox;
      
            thread = new Thread(Run);
            thread.Start();
        }

        void Run()
        {
            for (int i = 0; i < 30; i++) {
                _listBox.Items.Add("1");
                Thread.Sleep(400);
            }
        }
    }
}