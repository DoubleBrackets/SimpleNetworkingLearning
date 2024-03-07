using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTesting
{
    public partial class MainForm : Form
    {
        private MainFormControl control;

        public MainForm()
        {
            InitializeComponent();
            control = new MainFormControl(this, Console_TextBox);
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            control.ExecuteClient();
        }

        private async void StartServer_Button_Click(object sender, EventArgs e)
        {
            await Task.Run(control.ExecuteServer);
        }
    }
}
