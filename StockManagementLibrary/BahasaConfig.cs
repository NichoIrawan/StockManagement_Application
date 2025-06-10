using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagementLibrary
{
    public class BahasaConfig
    {
        public Config config;
        public const string filePath = @"Config.json";

        private JsonHandler<Config> _jsonHandler = new JsonHandler<Config>();

        public BahasaConfig()
        {
            try
            {
                config = _jsonHandler.ReadJsonFromFile(filePath);
            }
            catch (Exception)
            {
                config = new Config();
                SaveConfig(); // Save default if file doesn't exist
            }
        }

        public Config ReadConfigFile()
        {
            string file = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<Config>(file);
            return config;
        }
        public Bahasa GetCurrentLanguage()
        {
            config = ReadConfigFile(); // Ensure latest config is loaded
            return config.bahasa;
        }
        private void SaveConfig()
        {
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void ChangeLanguage(Bahasa newBahasa)
        {
            config.bahasa = newBahasa;
            SaveConfig(); // Save changes
        }
    }
}
