using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public ConfigFileManager fileConfig
        {
            get { return this.configFile; }
            set { if (value != null) configFile = value; }
        }

        private void ExitConfig()
        {
            Application.Exit();
        }

        public void ExitAndLaunchMainApp()
        {
            string root = configFile.GetRootPath();
            string mainAppPath =  Path.Combine(root, "mainApp", "bin", "Debug", "net10.0-windows", "mainApp.exe");
            Process.Start(mainAppPath);

            ExitConfig();
        }

        public void UpdateLastChangeTime()
        {
            configFile.Configuration.changeTime = DateTime.Now;
        }

        public void ResetConfig()
        {
            configFile.DeleteConfigFile();
            configFile.Configuration.Clear();
        }

        public string LastChangeInfo()
        {
            return "Last change saved on : " + configFile.Configuration.changeTime.ToString("HH:mm dd/MM/yyyy"); ;
        }
    }
}
