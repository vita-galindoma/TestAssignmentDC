using System.IO;
using Newtonsoft.Json;

namespace Assignment_DC.Configuration
{
    public class ConfigurationProvider
    {
        public static Configuration GetConfig()
        {
            var cfg = File.ReadAllText("settings.json");
            return JsonConvert.DeserializeObject<Configuration>(cfg);
        }
    }
}
