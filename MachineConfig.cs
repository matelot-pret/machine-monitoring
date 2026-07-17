using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
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
            set { name = value; }
        }

        public String Ipv4Address
        {
            get { return ipv4Address; }
            set { ipv4Address = value; }
        }

        public int PingRequestInterval
        {
            get { return pingRequestInterval; }
            set { pingRequestInterval = value; }
        }

        public static bool IsNameValid(string candidate)
        {
            return !String.IsNullOrWhiteSpace(candidate);
        }

        public static bool IsIpv4AddressValid(string candidate)
        {
            return IPAddress.TryParse(candidate, out IPAddress addr)
                && addr.AddressFamily == AddressFamily.InterNetwork;
        }

        public static bool IsPingRequestIntervalValid(int candidate)
        {
            return candidate > 0;
        }

        public bool IsValid()
        {
            return IsNameValid(name) && IsPingRequestIntervalValid(pingRequestInterval)
                && IsIpv4AddressValid(ipv4Address);
        }

    }
}
