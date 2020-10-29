using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace WarehouseProject
{
    /// <summary>
    /// Huvudklassen för Warehouse, där de olika katalogerna instansieras
    /// </summary>
    public class Warehouse
    {

        public CustomerCatalogue _customerCatalogue;
        public ProductCatalogue _productCatalogue;
        public OrderCatalogue _orderCatalogue;

        /// <summary>
        /// Instansierar kataloger för kunder, produkter och ordrar för applikationen
        /// </summary>
        /// <param name="customerFileName">En sträng</param>
        /// <param name="productFileName">En sträng</param>
        /// <param name="orderFileName">En sträng</param>
        public void StartWarehouse(string customerFileName, string productFileName, string orderFileName)
        {
            _customerCatalogue = new CustomerCatalogue(customerFileName);
            _productCatalogue = new ProductCatalogue(productFileName);
            _orderCatalogue = new OrderCatalogue(orderFileName, _customerCatalogue, _productCatalogue);
        }

        /// <summary>
        /// Skriver alla ändringar av katalogerna till respektive textfiler när applikationen stängs ner
        /// </summary>
        public void EndWarehouse()
        {
            _customerCatalogue.WriteCustomersToFile();
            _productCatalogue.WriteProductsToFile();
            _orderCatalogue.WriteProductsToFile();
        }
    }
}
