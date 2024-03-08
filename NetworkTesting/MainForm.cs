using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTesting
{
    public partial class MainForm : Form
    {
        private BasicConnectionControl basicConnectionControl;
        private OutputControl outputControl;

        public MainForm()
        {
            InitializeComponent();
            outputControl = new OutputControl(Console_TextBox);
            basicConnectionControl = new BasicConnectionControl(outputControl);
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            basicConnectionControl.ConnectAsClient();
        }

        private void StartServer_Button_Click(object sender, EventArgs e)
        {
            basicConnectionControl.StartServer();
        }

        private void StartInstance_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void IPAddress_TextBox_TextChanged(object sender, EventArgs e)
        {
            basicConnectionControl.targetIpv4Addr = IPAddress_TextBox.Text;
        }

        private void ShowIpInfo_Button_Click(object sender, EventArgs e)
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface network in networkInterfaces)
            {
                // Read the IP configuration for each network 
                IPInterfaceProperties properties = network.GetIPProperties();

                // Each network interface may have multiple IP addresses 
                foreach (IPAddressInformation address in properties.UnicastAddresses)
                {
                    outputControl.WriteToConsole(address.Address.ToString() + " (" + network.Name + ")");
                }
            }
        }
    }
}
