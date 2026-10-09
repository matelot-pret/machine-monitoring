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
        /// get/set last change time
        /// </summary>
        public DateTime ChangeTime
        {
            get { return lastChangeTime; }
            set { lastChangeTime = value; }
        }

        /// <summary>appends a machine to the list</summary>
        /// <param name="machine" the machine to add </param>
        public void AddMachineConfig (MachineConfig machine)
        {
                configMachines.Add(machine); 
        }

        /// <summary>Removes th given machine from the list</summary>
        /// <param name="bloc" the machine to remove</param>
        public void DeleteMachineConfig(MachineConfig bloc)
        {
            configMachines.Remove(bloc);
        }

        /// <summary>empties the machine list, resets the SMTP block to a new one, and sets ChangeTime to now. </summary>
        /// <notes>Used by the reset action</notes>
        public void ClearMachineConfig()
        {
            configMachines.Clear();
            configSmtp = new SMTPConfig();
            lastChangeTime = DateTime.Now;
        }

        /// <summary>tells whether the configuration is ready to launch monitoring</summary>
        /// <returns> <c> true</c> if at least one machine is valid and the SMTP block is Valid</returns></returns>
        /// <notes>gates the "exit and launch main app" button visibility
        public bool IsMachineConfigComplete()
        {
            foreach (MachineConfig machine in configMachines)
            {
                if (machine.IsMachineConfigValid()) { return configSmtp.IsSMTPConfigValid(); }
            }
            return false;
        }
    }
}
