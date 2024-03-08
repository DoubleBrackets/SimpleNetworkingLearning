using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTesting
{
    internal class OutputControl
    {
        private RichTextBox console;

        public OutputControl(RichTextBox console)
        {
            this.console = console;
            var x = console.Handle;

            WriteToConsole("Started :D");
        }

        public void WriteToConsole(string message)
        {

            console.Invoke((MethodInvoker)delegate {
                console.AppendText(message + "\n");
            });
        }
    }
}
