﻿using System;
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
        public List<Thread> Threads;
        public Semaphore Semaphore;
        private readonly string _semaphoreName = $"SEMAPHORE_{Guid.NewGuid()}";

        public MainForm()
        {
            InitializeComponent();

            Threads = new List<Thread>();
            Semaphore = new Semaphore((int)numSlotCount.Value, (int)numSlotCount.Value, _semaphoreName);

            // TODO: ...
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
