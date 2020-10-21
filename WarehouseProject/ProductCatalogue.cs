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

        public void WriteProductsToFile()
        {
            string content = JsonSerializer.Serialize(Products);
            File.WriteAllText(filename, content);
        }
        public List<Product> ProductsOutOfStock()
        {
            IEnumerable<Product> outOfStock = Products.Where(p => p.Stock == 0);
            return outOfStock.ToList();
        }

        public void AddProduct(Product newProduct)
        {
            this.Products.Add(newProduct);
        }

        public List<Product> AllProducts()
        {
            return Products;
        }

        public DateTime NextRestocking()
        {
            return Products.Min(p => p.NextStocking);
        }
    }
        
}
