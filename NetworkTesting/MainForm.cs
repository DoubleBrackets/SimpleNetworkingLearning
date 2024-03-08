using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTesting
{
    public partial class MainForm : Form
    {
        private BasicConnectionControl control;
        private OutputControl outputControl;

        public MainForm()
        {
            InitializeComponent();
            outputControl = new OutputControl(Console_TextBox);
            control = new BasicConnectionControl(outputControl);
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            control.ExecuteClient();
        }

        private void StartServer_Button_Click(object sender, EventArgs e)
        {
            control.StartServer();
        }

        private void StartInstance_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }
    }
}
