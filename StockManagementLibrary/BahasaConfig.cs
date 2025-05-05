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

        public BahasaConfig()
        {
            try
            {
                JsonHandler<Config>.readJsonFromFile(filePath);
            }
            catch (Exception)
            {
                config = new Config();
                JsonHandler<String>.writeJsonToFile(filePath, JsonSerializer.Serialize(config));
            }
        }
    }
}
