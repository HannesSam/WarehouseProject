using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    interface IDatabase
    {
        public dynamic ReadDataFromFile(string fileName);

        public void WriteDataToFile<T>(List<T> listOfObjects, string fileName);
    }
}
