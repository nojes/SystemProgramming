using System.Diagnostics;
using System.Windows.Forms;

namespace Processes.Helpers
{
    public class ProcessHelper
    {
        public static Process RunProcess(string assamblyName)
        {
            return Process.Start(assamblyName);
        }
    }
}