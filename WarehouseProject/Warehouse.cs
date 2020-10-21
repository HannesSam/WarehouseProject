using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Warehouse
    {

        public CustomerCatalogue CustomerCatalogue { get; set; }

        public void StartWarehouse()
        {
            CustomerCatalogue = new CustomerCatalogue();
        }

        //kör denna metod när applikationen stängs ner
        public void EndWarehouse()
        {
            CustomerCatalogue.WriteProductsToFile();
        }
    }
}
