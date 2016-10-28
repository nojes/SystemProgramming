using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_WinForm.Currency
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            MyThread thread1 = new MyThread(lbData);
//            Privat24 privat24 = new Privat24(lbCurrency, new DateTime(2016, 10, 1));
        }
    }
}
