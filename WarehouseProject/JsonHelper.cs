using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace WarehouseProject
{
    class JsonHelper
    {
        //Ska implementera denna men måste läsa på om generics först för att kunna passera in ett object som
        //Defineras först vid runtime. /HANNNNESSS
        public void WriteProductsToFile(string filename, object obj)
        {
            string contents = JsonSerializer.Serialize(obj);
            File.WriteAllText(filename, contents);
        }


        public List<Object> ReadProductsFromFile(string filename, List<Object> list)
        {
            if (File.Exists(filename))
            {
                string fileContents = File.ReadAllText(filename);
                list = JsonSerializer.Deserialize<List<object>>(fileContents);
            }
            else list = new List<object>();

            return list;
        }
    }
}
