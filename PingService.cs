using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;
using System.Net.NetworkInformation;
using System.Linq.Expressions;


namespace mainApp
{
    public class PingService
    {
        private readonly ManualResetEvent stopSignal = new ManualResetEvent(false);
        private readonly List<Thread> threads = new List<Thread>();

        private const int PingTimeout = 1000;

        /// <summary>
        /// starts one background thread per machine, each running MonitorMachine
        /// </summary>
        /// <param name="config"> the configuration whose machines to monitor</param>
        public void StartThreads(Config config)
        {
            foreach(MachineConfig machine in config.Machines)
            {
                Thread thread = new Thread(() => MonitorMachine(machine));
                thread.IsBackground = true;
                thread.Start();
                threads.Add(thread);
            }
        }

        /// <summary>
        /// pings the machine, then waits its interval on the stop signal and loops until the signal
        /// is set
        /// </summary>
        /// <param name="machine">the machine to monitor</param>
        private void MonitorMachine(MachineConfig machine)
        {
            do
            {
                SendPingRequest(machine);

            } while (stopSignal.WaitOne(machine.PingRequestInterval * 1000) is false);
        }

        /// <summary>
        /// signals all monitoring loops to stop 
        /// </summary>
        public void StopThreads()
        {
            stopSignal.Set();
        }

        /// <summary>
        /// sends one ping and writes the resulting state info into the machine
        /// </summary>
        /// <param name="machine">the target machine</param>
        /// <notes>a ping failure must never crash monitoring</notes>
        private static void SendPingRequest(MachineConfig machine)
        {
            //using reclose ressources at the end of the bloc
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send(machine.Ipv4Address, PingTimeout);
                    if (reply.Status == IPStatus.Success)
                    {
                        machine.State = CommunicationState.Functional;
                    }
                    else
                    {
                        machine.State = CommunicationState.NonFunctional;
                    }
                }
                catch (Exception)
                {
                    machine.State = CommunicationState.NonFunctional;
                }
            }
        }
    }
}
