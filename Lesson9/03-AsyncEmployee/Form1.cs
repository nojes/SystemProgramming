using System;
using System.Windows.Forms;
using _03_AsyncEmployee.Entities;

namespace _03_AsyncEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = await DataLayer.GetEmployeesAsync();
        }
    }
}
