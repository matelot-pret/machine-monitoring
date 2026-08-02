using System;
using System.Collections.Generic;
using System.Text;

namespace mainApp
{
    public class Config
    {
        private SMTPConfig configSmtp;
        private List<MachineConfig> configMachines;
        private DateTime lastChangeTime;

        /// <summary>builds an empty configuration (fresh SMTP block, empty machine list)</summary>
        public Config()
        {
            configSmtp = new SMTPConfig();
            configMachines = new List<MachineConfig>();
        }

        /// <summary>
        /// get/set the machine list
        /// </summary>
        public List<MachineConfig> Machines
        {
            get { return configMachines; }
            set { configMachines = value; }
        }

        /// <summary>
        /// get/set the smtp bloc
        /// </summary>
        public SMTPConfig Smtp
        {
            get { return configSmtp; }
            set { configSmtp = value; }
        }

        /// <summary>
        /// drops every machine that fails IsMachineConfigValid() from the list
        /// </summary>
        public void RemoveInvalidMachines()
        {
            configMachines.RemoveAll(machine => machine.IsMachineConfigValid() is false);
        }

        /// <summary>
        /// tells whether at least one machine is configured
        /// </summary>
        /// <returns>true if the list is non empty</returns>
        public bool HasOneMachine()
        {
            return configMachines.Count == 0; 
        }
    }
}
