using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Warehouse
    {

        CustomerCatalogue _customerCatalogue;

        public void StartWarehouse()
        {
            _customerCatalogue = new CustomerCatalogue();
            //customerCatalogue.AddTestData();
            //customerCatalogue.WriteProductsToFile();
            _customerCatalogue.ReadProductsFromFile();
        }

        //kör denna metod när applikationen stängs ner
        public void EndWarehouse()
        {
            _customerCatalogue.WriteProductsToFile();
        }
    }
}
