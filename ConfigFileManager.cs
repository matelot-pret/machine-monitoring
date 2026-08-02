using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace configApp
{
    
    public class ConfigFileManager
    {
        private string settingsPath;
        private string filePath;
        private Config config;

        /// <summary>
        /// Computes the settings/file paths from the solution root, 
        /// creates an empty Config then loads the file if present.
        /// </summary>
        public ConfigFileManager()
        {
            settingsPath = Path.Combine(GetRootPath(), "settings");
            filePath = Path.Combine(settingsPath, "config.json");
            config = new Config();
            LoadConfig();

        }

        public Config Configuration
        {
            get { return config; }
            set { config = value; }
        }

        /// <summary>
        /// Read and deserializes config.json into confifguration when the fie exists
        /// </summary>
        /// <return>the full path of that folder</return>
        public void LoadConfig()
        {
            if (IsConfigFileExists())
            {
                string json = File.ReadAllText(filePath);
                config = JsonSerializer.Deserialize<Config>(json) ?? new Config();
            }
        }

        /// <summary>
        /// finds the solution root by walking up from the binary location until a 
        /// folder containing a *.slnx file is found
        /// </summary>
        /// <returns>The full path of that folder</returns>
        public static string GetRootPath()
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

        /// <summary>
        /// creates the settings folder if needed and writes Configuration to config.json
        /// </summary>
        public void SaveConfigToJsonFile()
        {

            Directory.CreateDirectory(settingsPath);//create the directory if no exists

            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// deletes config.json if it exists
        /// </summary>
        public void DeleteConfigFile()
        {
            if (IsConfigFileExists())
            {
                File.Delete(filePath);
            }
        }

        /// <summary>
        /// tells whether config.json exists on disk
        /// </summary>
        /// <returns>true if the file exists</returns>
        public bool IsConfigFileExists()
        {
            return File.Exists(filePath);
        }

    }
}
