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

namespace _03_AsyncAwait.Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCalc_Click(object sender, EventArgs e)
        {
            textResult.Text = await LoadSum(textA.Text, textB.Text);
        }

        private Task<string> LoadSum(string a, string b)
        {
            return Task.Run(() => {
                Thread.Sleep(3000);
                return (Convert.ToInt32(a) + Convert.ToInt32(b)).ToString();
            });
        }
    }
}
