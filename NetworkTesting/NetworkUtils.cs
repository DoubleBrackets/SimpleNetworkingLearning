using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkTesting
{
    internal class NetworkUtils
    {
        [Flags]
        enum DeviceType
        {
            Client = 1 << 0,
            Server = 1 << 1
        }

        public static IEnumerable<NetworkInterface> GetNetworkInterfaces()
        {
            return NetworkInterface.GetAllNetworkInterfaces();
        }

        public static IEnumerable<IPAddressInformation> GetIPAddressInformation()
        {
            foreach (NetworkInterface network in GetNetworkInterfaces())
            {
                // Read the IP configuration for each network 
                IPInterfaceProperties properties = network.GetIPProperties();

                // Each network interface may have multiple IP addresses 
                foreach (IPAddressInformation address in properties.UnicastAddresses)
                {
                    yield return address;
                }
            }
        }

        public static IPAddressInformation GetWifiIPv4()
        {
            return NetworkUtils.GetNetworkInterfaces()
                .Where(network => network.NetworkInterfaceType == System.Net.NetworkInformation.NetworkInterfaceType.Wireless80211)
                .Where(network => network.Name == "Wi-Fi")
                .Select(network => network.GetIPProperties().UnicastAddresses)
                .SelectMany(addr => addr)
                .Where(addr => addr.Address.AddressFamily == AddressFamily.InterNetwork)
                .First();
        }

        public static IPAddressInformation GetLoopbbackAddress()
        {
            return NetworkUtils.GetNetworkInterfaces()
                .Select(network => network.GetIPProperties().UnicastAddresses)
                .SelectMany(addr => addr)
                .Where(addr => IPAddress.IsLoopback(addr.Address))
                .First();
        }

        public static IPAddress GetHostAssociatedAddress()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            // print addresses
            foreach (IPAddress ip in ipHost.AddressList)
            {
                Console.WriteLine(ip);

            }
            IPAddress ipAddr = ipHost.AddressList[0];
            return ipAddr;
        }

        internal static IEnumerable<IPAddressInformation> GetWifiAddresses()
        {
            return NetworkUtils.GetNetworkInterfaces()
                .Where(network => network.NetworkInterfaceType == System.Net.NetworkInformation.NetworkInterfaceType.Wireless80211)
                .Select(network => network.GetIPProperties().UnicastAddresses)
                .SelectMany(addr => addr)
                .Where(addr => {
                    bool isLoopback = IPAddress.IsLoopback(addr.Address);
                    bool isIpv4 = addr.Address.AddressFamily == AddressFamily.InterNetwork;
                    bool isIpv6 = addr.Address.AddressFamily == AddressFamily.InterNetworkV6;
                    return !isLoopback && (isIpv4 || isIpv6);
                    });
        }
    }
}
