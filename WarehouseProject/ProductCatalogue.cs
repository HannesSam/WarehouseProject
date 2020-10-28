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

        //denna borde döpas om till Products och resten av variablerna bör följa konventionen med små bokstäver
        //Om man inte är en prop!!
        public List<Product> ProductsProp { get { return Products; } set { Products = value; } }

        public delegate void UpdateProductList();

        public event UpdateProductList OnProductChange;

        public ProductCatalogue(string _filename)
        {
            this.filename = _filename;
            Products = ReadProductsFromFile();
            SetCount();
        }

        public void SetCount()
        {

            if (Products.Count == 0)
            {
                currentCode = 0;
            }
            else
            {
                currentCode = Products.Max(b => b.Code);
            }
        }
        public void WriteProductsToFile()
        {
            string contents = JsonSerializer.Serialize(Products);
            File.WriteAllText(filename, contents);
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

        public List<Product> ProductsOutOfStock()
        {
            IEnumerable<Product> outOfStock = Products.Where(p => p.Stock == 0);
            return outOfStock.ToList();
        }

        public void AddProduct(string name, double price, int stock, DateTime firstavailable, DateTime nextStock)
        {
            currentCode++;
            int code = currentCode;
            Product newProduct = new Product(code, name, price, stock, firstavailable, nextStock);
            this.Products.Add(newProduct);
            OnProductChange?.Invoke();
        }

        public List<Product> AllProducts()
        {
            return Products;
        }

        public DateTime NextRestocking()
        {
            return Products.Min(p => p.NextStocking);
        }

        public void UpdateInformation(int code, string name, double price, int stock, DateTime firstavailable, DateTime nextStock)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Code==code)
                {
                    Products[i].Name = name;
                    Products[i].Price = price;
                    Products[i].Stock = stock;
                    Products[i].FirstAvailable = firstavailable;
                    Products[i].NextStocking = nextStock;
                    OnProductChange?.Invoke();
                }
            }
        }
    }
        
}
