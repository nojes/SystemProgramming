using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsList
{
    public partial class MainForm : Form
    {
        private List<Thread> threads;
        private Semaphore semaphore;
        private string semaphoreName = $"SEMAPHORE_{Guid.NewGuid()}";

        public MainForm()
        {
            InitializeComponent();

            threads = new List<Thread>();
            semaphore = new Semaphore((int)numSlotCount.Value, (int)numSlotCount.Value, semaphoreName);

            // TODO: ...
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
