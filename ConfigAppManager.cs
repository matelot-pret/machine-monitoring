using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace configApp
{
    public class ConfigAppManager
    {
        private ConfigFileManager configFile;

        public ConfigFileManager fileConfig
        {
            get { return this.configFile; }
            set { if (value != null) configFile = value; }
        }

        public ConfigAppManager()
        {
            configFile = new ConfigFileManager();
        }

        public DateTime GetLastChangeTime()
        {
            return DateTime.Now;
        }

        private void ExitConfig()
        {
            Application.Exit();
        }

        public void ExitAndLaunchMainApp()
        {
            string mainAppPath = configFile.GetRootPath();
            Path.Combine(mainAppPath, "mainApp", "bin", "Debug", "net10.0-windows", "mainApp.exe");
            Process.Start(mainAppPath);

            ExitConfig();
        }
    }
}
