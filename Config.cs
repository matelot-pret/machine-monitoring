using System;
using System.Collections.Generic;
using System.Text;

namespace mainApp
{
    internal class Config
    {
        private SMTPConfig configSmtp;
        private List<MachineConfig> configMachines;
        private DateTime lastChangeTime;

        public Config()
        {
            configSmtp = new SMTPConfig();
            configMachines = new List<MachineConfig>();
        }

        public List<MachineConfig> Machines
        {
            get { return configMachines; }
            set { configMachines = value; }
        }

        public SMTPConfig Smtp
        {
            get { return configSmtp; }
            set { configSmtp = value; }
        }

        public DateTime ChangeTime
        {
            get { return lastChangeTime; }
            set { lastChangeTime = value; }
        }

        public void AddMachineConfig(MachineConfig machine)
        {
            configMachines.Add(machine);
        }

        public bool IsMachineConfigComplete()
        {
            foreach (MachineConfig machine in configMachines)
            {
                if (machine.IsMachineConfigValid()) { return configSmtp.IsSMTPConfigValid(); }
            }
            return false;
        }

        public bool HasOneMachine()
        {
            return configMachines.Count > 0; 
        }
    }
}
