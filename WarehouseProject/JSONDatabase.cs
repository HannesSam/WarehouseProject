using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WarehouseProject
{
    /// <summary>
    /// JSONM databas som sköter datalagringen i vår applikation i nuläget
    /// </summary>
    class JSONDatabase : IDatabase
    {

        /// <summary>
        /// Funktion som läser innehållet i en JSON fil och parsar om det till en array.
        /// </summary>
        /// <returns> Returnerar en array med innehållet i JSON filen </returns>
        public dynamic ReadDataFromFile(string fileName)
        {
            string fileContents = File.ReadAllText(fileName);
            JArray content = JArray.Parse(fileContents);
            return content;
        }

        /// <summary>
        /// En funktion som jobbar med generics för att kunna skriva en lista med objekt till en JSON fil.
        /// </summary>
        public void WriteDataToFile<T>(List<T> listOfObjects, string fileName)
        {
            string contents = JsonSerializer.Serialize(listOfObjects);
            File.WriteAllText(fileName, contents);
        }
    }
}
