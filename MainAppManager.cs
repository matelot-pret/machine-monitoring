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
        private Config config;
        private string settingsPath;
        private string filePath;

        public MainAppManager()
        {
            settingsPath = Path.Combine(GetRoothPath(), "settings");
            filePath = Path.Combine(settingsPath, "config.json");
            config = GetConfigFromFile();
        }

        public static string GetRoothPath()
        {
            DirectoryInfo? dir = new DirectoryInfo(AppContext.BaseDirectory);

            while(dir is not null && dir.GetFiles("*xlns").Length == 0)
            {
                dir = dir.Parent;
            }

            if(dir is null)
            {
                Environment.Exit(1); //projet path is broken
            }

            return dir.FullName;
        }

        public bool ConfigFileExists()
        {
            return File.Exists(filePath);
        }

        private Config GetConfigFromFile()
        {
            if (ConfigFileExists())
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Config>(json) ?? new Config();
            }

            return new Config();
        }

        public void ExitApp()
        {
            Environment.Exit(1);
        }

        public void LaunchMainApp()
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
