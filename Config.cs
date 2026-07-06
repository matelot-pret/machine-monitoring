using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class Config
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

        public DateTime changeTime
        {
            get { return lastChangeTime; }
            set { lastChangeTime = value; }
        }

        public void AddMachine (MachineConfig machine)
        {
                configMachines.Add(machine); 
        }

        public void DeleteMachine(MachineConfig bloc)
        {
            configMachines.Remove(bloc);
        }

        public void Clear()
        {
            configMachines.Clear();
            configSmtp = new SMTPConfig();
            lastChangeTime = DateTime.Now;
        }
    }
}
