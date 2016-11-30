using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Components;
using Employees.Models;

namespace Employees
{
    public partial class MainForm : Form
    {
        private Log log;

        public MainForm()
        {
            InitializeComponent();

            log = new Log {
                ListBox = lbLog,
                FileName = "log",
                FileExtension = "txt"
            };
        }

        private async void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string btnText = btnGenerateEmployee.Text;
            btnGenerateEmployee.Text = "Adding...";
            btnGenerateEmployee.Enabled = false;

            await AddEmployeeAsync();

            btnGenerateEmployee.Text = btnText;
            btnGenerateEmployee.Enabled = true;
        }

        private async Task AddEmployeeAsync()
        {
            Employee employee = await DataLayer.GetEmployeeAsync();
            lbEmployees.Items.Add(employee);
            log.WriteAsync($"Added {employee}");
        }

        private void lbEmployees_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            object currentEmployee = lbEmployees.Items[lbEmployees.SelectedIndex];

            lbEmployees.Items.RemoveAt(lbEmployees.SelectedIndex);
            log.WriteAsync($"Deleted {currentEmployee}");
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            new EditEmployeeForm().Show();
        }
    }
}
