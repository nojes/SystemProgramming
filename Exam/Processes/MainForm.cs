using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Processes.Helpers;

namespace Processes
{
    public partial class MainForm : Form
    {
        private List<Process> processes;

        public MainForm()
        {
            InitializeComponent();

            processes = new List<Process>();
        }

        private void btnRunCalc_Click(object sender, EventArgs e)
        {
            Process process = ProcessHelper.RunProcess("calc.exe");
            process.EnableRaisingEvents = true;
            process.Exited += Process_Exited;

            processes.Add(process);
            lbProcesses.Items.Add($"{process.ProcessName} - {process.Id}");
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            var process = sender as Process;
            if (process != null) {
                int index = lbProcesses.FindStringExact($"{process.ProcessName} - {process.Id}", -1);

                Invoke(new Action(() => lbProcesses.Items.RemoveAt(index)));
                processes.Remove(process);
            }
            
        }

        private void btnRunNotepad_Click(object sender, EventArgs e)
        {
            Process process = ProcessHelper.RunProcess("notepad.exe");
            processes.Add(process);
            process.EnableRaisingEvents = true;
            process.Exited += Process_Exited;

            lbProcesses.Items.Add($"{process.ProcessName} - {process.Id}");
        }

        private void lbProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbProcesses.SelectedIndex;

            lbProcesses.Items.RemoveAt(index);
            processes[index].Kill();
        }
    }
}
