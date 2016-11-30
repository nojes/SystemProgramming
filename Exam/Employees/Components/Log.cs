using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees.Components
{
    public class Log
    {
        public ListBox ListBox { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }

        public Log()
        {
            ListBox = new ListBox();
        }

        public void Write(string message)
        {
            string logMessage = $"[{DateTime.Now.ToLongTimeString()}]: {message}";
            ListBox.Items.Add(logMessage);

            if (FileName != null && FileExtension != null) {
                WriteToFile(logMessage);
            }
        }

        public void WriteAsync(string message)
        {
            string logMessage = $"[{DateTime.Now.ToLongTimeString()}]: {message}";
            ListBox.Items.Add(logMessage);

            if (FileName != null && FileExtension != null) {
                WriteToFileAsync(logMessage);
            }
        }

        public void WriteToFile(string message)
        {
            using (StreamWriter writer = File.CreateText(
                $"{FileName}-{DateTime.Now.ToLongTimeString()}.{FileExtension}"
            )) {
                writer.Write(message);
            }
        }

        public async void WriteToFileAsync(string message)
        {
            string path = $"{FileName}_{DateTime.Now:yyyy-MM-dd}.{FileExtension}";

            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path)) {
                    await writer.WriteLineAsync(message);
                }
            }
            else
            {
                using (StreamWriter writer = File.AppendText(path)) {
                    await writer.WriteLineAsync(message);
                }
            }
        }
    }
}