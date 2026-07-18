using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace configApp
{
    public class ConfigFileManager
    {
        private string filePath;
        private Config config;

        public ConfigFileManager()
        {
            filePath = GetConfigFilePath();
            config = new Config();
            LoadConfig();

        }

        public void LoadConfig()
        {
            if (IsConfigFileExists())
            {
                string json = File.ReadAllText(filePath);
                config = JsonSerializer.Deserialize<Config>(json) ?? new Config();
            }
        }

        public Config Configuration {
            get { return config; }
            set { config = value; }
        }

        public string pathFile
        {
            get { return filePath; }
            //no need to be change by another object
        }

        public string GetRootPath()
        {
            //Anchor on the binary location, the working directory is weak
            DirectoryInfo? dir = new DirectoryInfo(AppContext.BaseDirectory);

            while(dir != null && dir.GetFiles("*.slnx").Length == 0)
            {
                dir = dir.Parent;
            }

            if(dir == null)
            {
                //if dir is null there is nothing i can do, the projet path is broken
                Environment.Exit(1);
            }
            

            return dir.FullName;
        }

        private string GetConfigFilePath()
        {
            return Path.Combine(GetRootPath(), "settings", "config.json");
        }

        public void SaveConfigToJsonFile()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));//create the directory if no exists

            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void DeleteConfigFile()
        {
            if (IsConfigFileExists())
            {
                File.Delete(filePath);
            }
        }

        public bool IsConfigFileExists()
        {
            return File.Exists(filePath);
        }

    }
}
