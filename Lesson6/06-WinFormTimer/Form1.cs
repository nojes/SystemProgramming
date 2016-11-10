using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_WinFormTimer
{
    public partial class Form1 : Form
    {
        private int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0;
            InitListBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++count;
            if (count % 2 == 0) {
                listBox.Items[0] = $"Even {count}";
            }
            else {
                listBox.Items[1] = $"Not even {count}";
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            InitListBox();
        }

        private void InitListBox()
        {
            listBox.Items[0] = "Even";
            listBox.Items[1] = "Not even";
        }
    }
}
