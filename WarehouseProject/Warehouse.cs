using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Warehouse
    {
        public void StartWarehouse()
        {
            CustomerCatalogue customerCatalogue = new CustomerCatalogue();
            //customerCatalogue.AddTestData();
            //customerCatalogue.WriteProductsToFile();
            customerCatalogue.ReadProductsFromFile();
        }
    }
}
