using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WebClient.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            textURL.Text = "https://habrahabr.ru/";
            statusStrip.Items["toolStripStatusLabel"].Text = "Ready";
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try {
                statusStrip.Items["toolStripStatusLabel"].Text = "Loading...";
                var client = new WebClient { Encoding = Encoding.UTF8 };

                //richTextData.Text = client.DownloadString(textURL.Text);

                richTextData.Text = await client.DownloadStringTaskAsync(textURL.Text);
                statusStrip.Items["toolStripStatusLabel"].Text = "Successfully loaded.";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
