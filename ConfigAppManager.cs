using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class ConfigAppManager
    {
        private ConfigFileManager configFile;

        public ConfigAppManager()
        {
            configFile = new ConfigFileManager();
        }

        public DateTime GetLastChangeTime()
        {
            return DateTime.Now;
        }
    }
}
