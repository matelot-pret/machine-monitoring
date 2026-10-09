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

        /// <summary>builds a machine with empty name and empty IPv4 address.</summary>
        public MachineConfig() {
            name = String.Empty;
            ipv4Address = String.Empty;
        }

        /// <summary>
        /// get/set machine name
        /// </summary>
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// get/set Ipv4 Address
        /// </summary>
        public String Ipv4Address
        {
            get { return ipv4Address; }
            set { ipv4Address = value; }
        }

        /// <summary>
        /// get/set the ping request interval in seconds
        /// </summary>
        public int PingRequestInterval
        {
            get { return pingRequestInterval; }
            set { pingRequestInterval = value; }
        }

        /// <summary> tells whether a name is non-empty.</summary>
        /// <param name="candidate">the name to test </param>
        /// <returns>true if not null/whitespace</returns>
        public static bool IsNameValid(string candidate)
        {
            return !String.IsNullOrWhiteSpace(candidate);
        }

        /// <summary>tells whether a string is a canonical dotted IPv4 Address</summary>
        /// <param name="candidate"> the raw string</param>
        /// <returns>true if it parses to an IPv4 and re-stringifies identically(rejects dotless/shortland/octal forms</returns>
        public static bool IsIpv4AddressValid(string candidate)
        {
            return IPAddress.TryParse(candidate.Trim(), out IPAddress? addr)
                && addr.AddressFamily == AddressFamily.InterNetwork
                && addr.ToString() == candidate;
        }

        /// <summary>tells wether the interval is strictly positive</summary>
        /// <param name="candidate" > seconds between pings</param>
        /// <returns>true is candidate > 0 </returns>
        public static bool IsPingRequestIntervalValid(int candidate)
        {
            return candidate > 0;
        }

        /// <summary>tells whether this machine's stored fields are all valid.</summary>
        /// <returns>true if name, interval and IPv4 are all valid.</returns>
        public bool IsMachineConfigValid()
        {
            return IsNameValid(name) && IsPingRequestIntervalValid(pingRequestInterval)
                && IsIpv4AddressValid(ipv4Address);
        }

    }
}
