using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NFC_Reader
{
    internal class JsonInput
    {
        public class InnerData
        {
            public string? outputString { get; set; }
            public int? numberOfData { get; set; }
        }

        public class JsonData
        {
            public Dictionary<string, InnerData> DataSets { get; set; }
        }

        public JsonData ReadJsonData(string filePath)
        {
            JsonData jsonData = new JsonData();

            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                jsonData.DataSets = JsonSerializer.Deserialize<Dictionary<string, InnerData>>(jsonContent);
            }

            return jsonData;
        }
    }
}



    

