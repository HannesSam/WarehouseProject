using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace WarehouseProject
{
    class JSONDatabase : IDatabase
    {
        public dynamic ReadDataFromFile(string fileName)
        {
            string fileContents = File.ReadAllText(fileName);
            JArray content = JArray.Parse(fileContents);
            return content;
        }

        public void WriteDataToFile<T>(List<T> listOfObjects, string fileName)
        {
            string contents = JsonSerializer.Serialize(listOfObjects);
            File.WriteAllText(fileName, contents);
        }
    }
}
