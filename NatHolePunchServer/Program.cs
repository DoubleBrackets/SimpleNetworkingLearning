using System.Net.Sockets;
using System.Net;
using System.Text;

namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ExecuteServer();
    }

    public const string TerminationString = "<EOF>";

    private static void ExecuteServer()
    {
        Console.WriteLine("Starting Server");

        // Use IPv6Any to listen on all network interfaces
        // https://stackoverflow.com/questions/1285953/c-sharp-server-that-supports-ipv6-and-ipv4-on-the-same-port

        IPAddress ipAddr = IPAddress.IPv6Any;
        IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 7770);

        Socket listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        // Allow both ipv4 and ipv6 connections
        listener.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
        try
        {

            Console.WriteLine($"Binding to \n{Dns.GetHostEntry(Dns.GetHostName()).AddressList[0]}:{localEndPoint.Port}");


            listener.Bind(localEndPoint);

            // Non-blocking; set into listening state
            listener.Listen(10);

            while (true)
            {

                Console.WriteLine("Waiting for client to connect... ");

                // Suspend while waiting for incoming connection
                Socket clientSocket = listener.Accept();

                var clientEndPoint = (IPEndPoint)clientSocket.RemoteEndPoint;
                Console.WriteLine($"Connection received from \n{clientEndPoint.Address}:{clientEndPoint.Port} ");

                // Data buffer
                byte[] bytes = new Byte[1024];
                string data = null;

                while (true)
                {
                    Console.WriteLine("Waiting for incoming bytes ... ");

                    int numByte = clientSocket.Receive(bytes);

                    data += Encoding.ASCII.GetString(bytes,
                                               0, numByte);

                    if (data.IndexOf(TerminationString) > -1)
                        break;
                }

                Console.WriteLine($"Text received -> {data} ");

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