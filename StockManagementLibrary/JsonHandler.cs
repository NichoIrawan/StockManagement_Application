using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagementLibrary
{
    public static class JsonHandler<T>
    {
        public static T? readJsonFromFile(string filepath)
        {
            string json = File.ReadAllText(filepath);
            T data = JsonSerializer.Deserialize<T>(json);

            return data;
        }

        public static void writeJsonToFile(string filepath, T data)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filepath, json);
        }
    }
}
