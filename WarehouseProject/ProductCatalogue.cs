using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace WarehouseProject
{
    public class ProductCatalogue
    {
        private List<Product> Products;
        private string filename;
        public int currentCode;

        public ProductCatalogue(string _filename)
        {
            this.filename = _filename;
            Products = ReadProductsFromFile();
            //currentCode = Products.Max(b => b.Code);
        }

        private List<Product> ReadProductsFromFile()
        {
            if (File.Exists(filename))
            {
                string fileContents = File.ReadAllText(filename);
                Products = JsonSerializer.Deserialize<List<Product>>(fileContents);
            }
            else Products = new List<Product>();

            return Products;
        }

        public void AddProduct(Product newProduct)
        {
            this.Products.Add(newProduct);
        }

        //public List<Product> AllProducts()
        //{

        //}

        //public List<Product> ProductOutOfStock()
        //{

        //}

        public DateTime NextRestocking(Product product)
        {
            return product.NextStocking;
        }
    }
        
}
