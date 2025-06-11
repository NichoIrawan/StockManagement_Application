using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagementLibrary
{
    public class JsonHandler<T>
    {
        private static JsonHandler<T>? _instance;
        private readonly JsonSerializerOptions _options;

        // Private constructor agar kelas tidak dibuat berkali-kali
        private JsonHandler()
        {
            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };
        }

        // Singleton instance untuk mengakses JsonHandler
        public static JsonHandler<T> GetInstance()
        {
            _instance ??= new ();

            return _instance;
        }

        // Metode untuk membaca objek dari JSON string
        public T? ReadJsonFromFile(string filepath)
        {
            string json = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<T>(json, _options);
        }

        // Metode untuk menulis objek ke JSON string
        public void WriteJsonToFile(string filepath, T data)
        {
            string json = JsonSerializer.Serialize(data, _options);
            File.WriteAllText(filepath, json);
        }
    }
}
