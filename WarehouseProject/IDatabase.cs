using System.Collections.Generic;

namespace WarehouseProject
{

    /// <summary>
    /// Interface som sköter kontakten med databasen för att i framtiden kunna använda andra typer av databaser
    /// </summary>
    interface IDatabase
    {
        public dynamic ReadDataFromFile(string fileName);

        public void WriteDataToFile<T>(List<T> listOfObjects, string fileName);
    }
}
