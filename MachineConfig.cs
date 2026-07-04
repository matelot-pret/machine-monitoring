using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace configApp
{
    public class MachineConfig
    {
        private String name;
        private String ipv4Address;
        private int pingRequestInterval;

        public MachineConfig() { }

        public String Name
        {
            get { return name; }
            set { if (!String.IsNullOrWhiteSpace(value)) name = value; }
        }

        public String Ipv4Address
        {
            get { return ipv4Address; }
            set { if (!String.IsNullOrWhiteSpace(value)) ipv4Address = value; }
        }

        public int PingRequestInterval
        {
            get { return pingRequestInterval; }
            set { if (value > 0) pingRequestInterval = value; }
        }

        public bool IsNameEmpty()
        {
            return String.IsNullOrWhiteSpace(name);
        }

        public bool IsIpv4AddressValid()
        {
            return IPAddress.TryParse(ipv4Address, out IPAddress addr) 
                && addr.AddressFamily == AddressFamily.InterNetwork;
        }

        public bool IsPingRequestIntervalValid()
        {
            return pingRequestInterval > 0;
        }

    }
}
