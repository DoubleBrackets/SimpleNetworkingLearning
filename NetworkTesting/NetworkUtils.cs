using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
