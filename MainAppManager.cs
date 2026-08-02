using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json;

namespace mainApp
{
    internal class MainAppManager
    {
        private readonly Config config;
        private readonly string settingsPath;
        private readonly string filePath;
        private readonly PingService pingService;

        /// <summary>
        ///  computes paths, loads the config, 
        ///  filters out invalid machines, and creates the (not yet started) PingService.
        /// </summary>
        public MainAppManager()
        {
            settingsPath = Path.Combine(GetRoothPath(), "settings");
            filePath = Path.Combine(settingsPath, "config.json");
            config = GetConfigFromFile();
            config.RemoveInvalidMachines();
            pingService = new PingService();
        }

        /// <summary>
        /// get the config
        /// </summary>
        public Config Config
        {
            get { return config; }
        }

        /// <summary>
        ///  starts one monitoring thread per valid machine. 
        /// </summary>
        /// <notes>must be called after screen + notifier are wired.</notes>
        public void StartPings()
        {
            pingService.StartThreads(config);
        }

        /// <summary>
        /// signals every monitoring thread to stop.
        /// </summary>
        public void StopPing()
        {
            pingService.StopThreads();
        }

        /// <summary>
        ///  finds the solution root by walking up until a *.slnx is found.
        /// </summary>
        /// <returns>this folder's full path. </returns>
        public static string GetRoothPath()
        {
            DirectoryInfo? dir = new DirectoryInfo(AppContext.BaseDirectory);

            while(dir is not null && dir.GetFiles("*.slnx").Length == 0)
            {
                dir = dir.Parent;
            }

            if(dir is null)
            {
                Environment.Exit(1); //projet path is broken
            }

            return dir.FullName;
        }

        /// <summary>
        ///  tells whether config.json exists. 
        /// </summary>
        /// <returns>true if the file exists</returns>
        public bool ConfigFileExists()
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// reads and deserializes config.json, or returns a new empty Config if the file is missing.
        /// </summary>
        /// <returns>the loaded configuration.</returns>
        private Config GetConfigFromFile()
        {
            if (ConfigFileExists())
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Config>(json) ?? new Config();
            }

            return new Config();
        }

        /// <summary>
        /// exits the process cleanly
        /// </summary>
        public void ExitApp()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// launches the compiled configApp.exe (mirror path) then exits.
        /// </summary>
        /// <notes>no operation if the exe is not found.</notes>
        public void LaunchConfigApp()
        {
            string layout = Path.GetRelativePath(Path.Combine(GetRoothPath(), "mainApp"), AppContext.BaseDirectory);
            string configAppPath = Path.Combine(GetRoothPath(), "configApp", layout, "configApp.exe");

            if (!File.Exists(configAppPath))
            {
                return; //nothing to launch
            }

            Process.Start(configAppPath);

            ExitApp();
        }
    }
}
