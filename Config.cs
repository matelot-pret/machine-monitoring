using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class Config
    {
        private SMTPConfig configSmtp;
        private List<MachineConfig> configMachine;
        private DateTime lastChangeTime;

        public Config()
        {
            configSmtp = new SMTPConfig();
            configMachine = new List<MachineConfig>();
        }

        public DateTime changeTime
        {
            get { return lastChangeTime; }
            set { if (value != null) lastChangeTime = value; }
        }

        public bool isMachineValid(MachineConfig machine)
        {
            return machine.IsPingRequestIntervalValid() 
                && machine.IsNameEmpty() && machine.IsIpv4AddressValid();
        }

        public void AddMachine (MachineConfig machine)
        {
            if (isMachineValid(machine))
            {
                configMachine.Add(machine);
            }
        }

    }
}
