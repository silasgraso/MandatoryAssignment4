using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MandatoryAssignment4
{
    public class ConfigurationReader
    {
        public World ReadConfiguration(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<World>(json);
        }
    }
}
