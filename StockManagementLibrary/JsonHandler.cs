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
        private JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        private JsonHandler<T> _jsonHandler;

        public JsonHandler()
        {
            _jsonHandler = GetJsonHandler();
        }

        private JsonHandler<T> GetJsonHandler()
        {
            if (_jsonHandler == null)
            {
                _jsonHandler = new JsonHandler<T>();
            }

            return _jsonHandler;
        }

        public T? ReadJsonFromFile(string filepath)
        {
            string json = File.ReadAllText(filepath);
            T data = JsonSerializer.Deserialize<T>(json);

            return data;
        }

        public void WriteJsonToFile(string filepath, T data)
        {
            string json = JsonSerializer.Serialize(data, _options);
            File.WriteAllText(filepath, json);
        }
    }
}
