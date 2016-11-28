using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_AsyncAwait.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            lblText.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lblText.Enabled = false;

            lblText.Text = GetText();

            lblText.Enabled = true;
            lblText.Visible = true;
        }

        private async void btnLoadAsync_Click(object sender, EventArgs e)
        {
            lblText.Enabled = false;

            lblText.Text = await GetTextAsync();

            lblText.Enabled = true;
            lblText.Visible = true;
        }

        private string GetText()
        {
            Thread.Sleep(3000);
            return "Text";
        }

        private Task<string> GetTextAsync()
        {           
            return Task.Run(() => {
                Thread.Sleep(3000);
                return "Text";
            });
        }
    }
}
