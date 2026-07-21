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

        private void MonitorMachine(MachineConfig machine)
        {
            do
            {
                SendPingRequest(machine);

            } while (stopSignal.WaitOne(machine.PingRequestInterval * 1000) is false);
        }

        public void StopThreads()
        {
            stopSignal.Set();
        }

        public void SendPingRequest(MachineConfig machine)
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
                catch (PingException)
                {
                    machine.State = CommunicationState.NonFunctional;
                }
            }
        }
    }
}
