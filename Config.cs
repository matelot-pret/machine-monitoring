using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class Config
    {
        private SMTPConfig configSmtp;
        private List<MachineConfig> configMachine;

        public Config()
        {
            configSmtp = new SMTPConfig();
            configMachine = new List<MachineConfig>();
        }


    }
}
