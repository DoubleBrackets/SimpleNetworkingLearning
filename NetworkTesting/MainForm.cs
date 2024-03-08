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
        private BasicTCPConnectionControl basicConnectionControl;
        private BasicUDPConnectionControl basicUDPConnectionControl;
        private OutputControl outputControl;

        public MainForm()
        {
            InitializeComponent();
            outputControl = new OutputControl(Console_TextBox);
            basicConnectionControl = new BasicTCPConnectionControl(outputControl);
            basicUDPConnectionControl = new BasicUDPConnectionControl(outputControl);
        }

        private void BasicTCPConnect_Button_Click(object sender, EventArgs e)
        {
            basicConnectionControl.ConnectAsClient();
        }

        private void BasicTCPStartServer_Button_Click(object sender, EventArgs e)
        {
            basicConnectionControl.StartServer();
        }

        private void StartInstance_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void IPAddress_TextBox_TextChanged(object sender, EventArgs e)
        {
            basicConnectionControl.targetIpAddr = BasicTCPIPAddress_TextBox.Text.Trim();
        }

        private void ShowIpInfo_Button_Click(object sender, EventArgs e)
        {
            foreach (NetworkInterface network in NetworkUtils.GetNetworkInterfaces())
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

        private void BasicUDPIP_Textbox_TextChanged(object sender, EventArgs e)
        {
            basicUDPConnectionControl.targetIpAddr = BasicUDPIP_Textbox.Text.Trim();
        }

        private void BasicUDPStartListening_Button_Click(object sender, EventArgs e)
        {
            basicUDPConnectionControl.StartServer();
        }

        private void BasicUDPConnect_Button_Click(object sender, EventArgs e)
        {
            basicUDPConnectionControl.ConnectAsClient();
        }
    }
}
