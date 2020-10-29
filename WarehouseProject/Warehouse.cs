namespace WarehouseProject
{
    /// <summary>
    /// Huvudklassen för Warehouse, där de olika katalogerna instansieras
    /// </summary>
    public class Warehouse
    {

        public ICustomerCatalogue _customerCatalogue;
        public IProductCatalogue _productCatalogue;
        public IOrderCatalogue _orderCatalogue;

        /// <summary>
        /// Instansierar kataloger för kunder, produkter och ordrar för applikationen, tar emot namnen på JSON-filerna
        /// </summary>
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
            _orderCatalogue.WriteOrdersToFile();
        }
    }
}
