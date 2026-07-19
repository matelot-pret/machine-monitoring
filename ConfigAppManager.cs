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

        public ConfigFileManager FileConfig
        {
            get { return this.configFile; }
            set { if (value != null) configFile = value; }
        }

        private static void ExitConfig()
        {
            Application.Exit();
        }

        public static void ExitAndLaunchMainApp()
        {
            string root = ConfigFileManager.GetRootPath();
            string layout = Path.GetRelativePath(Path.Combine(root, "configApp"), AppContext.BaseDirectory);

            string mainAppPath =  Path.Combine(root, "mainApp", layout, "mainApp.exe");

            if (!File.Exists(mainAppPath))
            {
                return;//nothing to launch
            }

            Process.Start(mainAppPath);
            ExitConfig();
        }

        public void UpdateLastChangeTime()
        {
            configFile.Configuration.ChangeTime = DateTime.Now;
        }

        public void ResetConfig()
        {
            configFile.DeleteConfigFile();
            configFile.Configuration.ClearMachineConfig();
        }

        public string LastChangeInfo()
        {
            return "Last change saved on : " + configFile.Configuration.ChangeTime.ToString("HH:mm dd/MM/yyyy"); ;
        }
    }
}
