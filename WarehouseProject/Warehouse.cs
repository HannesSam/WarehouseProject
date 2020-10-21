using System;
using System.Collections.Generic;
using System.Text;

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
            _orderCatalogue = new OrderCatalogue(orderFileName);
        }

        //kör denna metod när applikationen stängs ner
        public void EndWarehouse()
        {
            _customerCatalogue.WriteProductsToFile();
        }
    }
}
