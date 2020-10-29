using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public interface IProductCatalogue
    {
        List<Product> Products { get; set; }
        void SetCount();

        void WriteProductsToFile();

        void AddProduct(string name, double price, int stock, DateTime firstavailable, DateTime nextStock);
        List<Product> AllProducts();
        DateTime NextRestocking();
        void UpdateInformation(int code, string name, double price, int stock, DateTime firstavailable, DateTime nextStock);

        List<Product> ProductsOutOfStock();


    }
}
