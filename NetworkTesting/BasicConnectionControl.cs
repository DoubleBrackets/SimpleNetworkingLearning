using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NetworkTesting
{
    internal class BasicConnectionControl
    {
        private OutputControl outputControl;

        private const int Port = 7770;

        public string targetIpAddr { get; set; }

        private CancellationTokenSource cancelTokenSource;

        public const string TerminationString = "<EOF>";    

        public enum State
        {
            Idle,
            ClientInProgress,
            ServerInProgress
        }

        public State state { get; set; }

        public BasicConnectionControl(OutputControl outputControl)
        {        
            this.outputControl = outputControl;
            cancelTokenSource = new CancellationTokenSource();
        }

        public async void ConnectAsClient()
        {
            if(state == State.ClientInProgress)
            {
                cancelTokenSource.Cancel();
                return;
            }

            var progress = new Progress<string>(s => outputControl.WriteToConsole(s));
            await Task.Run(() => ExecuteClient(progress, cancelTokenSource.Token));
        }

        private void ExecuteClient(IProgress<string> progress, CancellationToken token)
        {
           
            progress.Report("Starting Client");
            try
            {
                IPAddress ipAddr = NetworkUtils.GetHostAssociatedAddress();

                if (targetIpAddr != null && targetIpAddr != String.Empty)
                {
                    ipAddr = IPAddress.Parse(targetIpAddr);
                }

                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, Port);

                progress.Report($"Trying to connect to -> \n{ipAddr}\non port {localEndPoint.Port}");

                Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(localEndPoint);

                    progress.Report($"Socket connected to -> {sender.RemoteEndPoint.ToString()}");

                    string message = "Test client says hi!";
                    byte[] messageSent = Encoding.ASCII.GetBytes(message + TerminationString);

                    int byteSent = sender.Send(messageSent);

                    progress.Report($"Sent bytes:  -> {Encoding.ASCII.GetString(messageSent)}");

                    // Data buffer
                    byte[] messageReceived = new byte[1024];

                    progress.Report($"Waiting for response...");

                    // Receive data from the server
                    int byteRecv = sender.Receive(messageReceived);
                    string parsedResponse = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
                    progress.Report($"Message from Server -> {parsedResponse}");

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }

                catch (ArgumentNullException ane)
                {

                    progress.Report($"ArgumentNullException : {ane.ToString()}");
                }

                catch (SocketException se)
                {

                    progress.Report($"SocketException : {se.ToString()}");
                }

                catch (Exception e)
                {
                    progress.Report($"Exception : {e.ToString()}");
                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }

        public async void StartServer()
        {
            var progress = new Progress<string>(s => outputControl.WriteToConsole(s));
            await Task.Run(() => ExecuteServer(progress));
        }
        private void ExecuteServer(IProgress<string> progress)
        {
            progress.Report("Starting Server");

            // Use IPv6Any to listen on all network interfaces
            // https://stackoverflow.com/questions/1285953/c-sharp-server-that-supports-ipv6-and-ipv4-on-the-same-port

            IPAddress ipAddr = IPAddress.IPv6Any;
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, Port);

            Socket listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Allow both ipv4 and ipv6 connections
            listener.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
            try
            {
                progress.Report($"Binding to ip \n{ipAddr}\non port {localEndPoint.Port}");

                listener.Bind(localEndPoint);

                // Non-blocking; set into listening state
                listener.Listen(10);

                while (true)
                {

                    progress.Report("Waiting for connection to send data... ");

                    // Suspend while waiting for incoming connection
                    Socket clientSocket = listener.Accept();

                    progress.Report("Connection received ... ");

                    // Data buffer
                    byte[] bytes = new Byte[1024];
                    string data = null;

                    while (true)
                    {
                        progress.Report("Waiting for incoming bytes ... ");

                        int numByte = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes,
                                                   0, numByte);

                        if (data.IndexOf(TerminationString) > -1)
                            break;
                    }

                    progress.Report($"Text received -> {data} ");

                    byte[] message = Encoding.ASCII.GetBytes("The server sees you :O");

                    // Send a message to Client 
                    // using Send() method
                    clientSocket.Send(message);

                    // Close client Socket using the
                    // Close() method. After closing,
                    // we can use the closed Socket 
                    // for a new Client Connection
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
