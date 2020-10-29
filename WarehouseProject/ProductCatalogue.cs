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
        private List<Product> _products;
        private string _fileName;
        public int _currentCode;
        private IDatabase database;
        //denna borde döpas om till Products och resten av variablerna bör följa konventionen med små bokstäver
        //Om man inte är en prop!!
        public List<Product> Products { get { return _products; } set { _products = value; } }

        public ProductCatalogue(string filename)
        {
            database = new JSONDatabase();
            _fileName = filename;
            Products = ReadProductsFromFile(_fileName);
            SetCount();
        }

        public void SetCount()
        {

            if (Products.Count == 0)
            {
                _currentCode = 0;
            }
            else
            {
                _currentCode = Products.Max(b => b.Code);
            }
        }
        public void WriteProductsToFile()
        {
            database.WriteDataToFile(Products, _fileName);
        }

        private List<Product> ReadProductsFromFile(string fileName)
        {
            var data = database.ReadDataFromFile(fileName);
            List<Product> returnData = data.ToObject<List<Product>>();
            return returnData;
        }

        public List<Product> ProductsOutOfStock()
        {
            IEnumerable<Product> outOfStock = Products.Where(p => p.Stock == 0);
            return outOfStock.ToList();
        }

        public void AddProduct(string name, double price, int stock, DateTime firstavailable, DateTime nextStock)
        {
            _currentCode++;
            int code = _currentCode;
            Product newProduct = new Product(code, name, price, stock, firstavailable, nextStock);
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
                }
            }
        }
    }
        
}
