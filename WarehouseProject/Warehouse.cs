using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace WarehouseProject
{
    public class Warehouse
    {

        public CustomerCatalogue _customerCatalogue;
        public ProductCatalogue _productCatalogue;
        public OrderCatalogue _orderCatalogue;

        public void StartWarehouse(string customerFileName, string productFileName, string orderFileName)
        {
            _customerCatalogue = new CustomerCatalogue(customerFileName);
            _productCatalogue = new ProductCatalogue(productFileName);
            _orderCatalogue = new OrderCatalogue(orderFileName, _customerCatalogue, _productCatalogue);
        }

        //kör denna metod när applikationen stängs ner
        public void EndWarehouse()
        {
            _customerCatalogue.WriteCustomersToFile();
            _productCatalogue.WriteProductsToFile();
            _orderCatalogue.WriteOrdersToFile();
        }
    }
}
