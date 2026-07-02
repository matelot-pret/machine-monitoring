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
        }

        private string GetRootPath()
        {
            string path = " ";

            string actualPath = Path.GetFullPath(".");
            for(int i = 0; i < 4; i++)
            {
                path = Directory.GetParent(actualPath).FullName;

                actualPath = path;
            }

            return path;
        }

        private string GetConfigFilePath()
        {
            return Path.Combine(GetRootPath(), "settings", "config.json");
        }

        public void SaveConfigToJsonFile()
        {
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

    }
}
