using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace configApp
{
    public class ConfigAppManager
    {
        private ConfigFileManager configFile;

        /// <summary>
        /// builds the file manager(which loads the config)
        /// </summary>
        public ConfigAppManager()
        {
            configFile = new ConfigFileManager();
        }

        /// <summary>
        /// get/set the file config. Ignores null
        /// </summary>
        public ConfigFileManager FileConfig
        {
            get { return this.configFile; }
            set { if (value != null) configFile = value; }
        }

        /// <summary>
        /// requests application shutdown
        /// </summary>
        private static void ExitConfig()
        {
            Application.Exit();
        }

        /// <summary>
        /// Launches the compiled MainApp.exe then exists configApp
        /// </summary>
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

        /// <summary>
        /// set the configuration's changeTime to now
        /// </summary>
        public void UpdateLastChangeTime()
        {
            configFile.Configuration.ChangeTime = DateTime.Now;
        }


        /// <summary>
        /// deletes the config file and clears the in-memory machine list + SMTP block
        /// </summary>
        public void ResetConfig()
        {
            configFile.DeleteConfigFile();
            configFile.Configuration.ClearMachineConfig();
        }


        /// <summary>
        /// builds a human-deadable "last change saved on...
        /// </summary>
        /// <returns>the formated timestamp string</returns>
        public string LastChangeInfo()
        {
            return "Last change saved on : " + configFile.Configuration.ChangeTime.ToString("HH:mm dd/MM/yyyy"); ;
        }
    }
}
