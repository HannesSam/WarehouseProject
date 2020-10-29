using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace WarehouseProject
{
    /// <summary>
    /// Huvudklassen för produktkatalogen, innehåller alla funktioner för läsa och skriva till datbasen, lägga till och uppdatera produkter
    /// </summary>
    public class ProductCatalogue : IProductCatalogue
    {
        private List<Product> _products;
        private string _fileName;
        private int _currentCode;
        private IDatabase database;


        public List<Product> Products { get { return _products; } set { _products = value; } }

        public delegate void UpdateProductList();

        public event UpdateProductList OnProductChange;

        /// <summary>
        /// Konstruktor för att instansiera och skapa ett produkt-objekt i katalogen, tar emot namnet på katalogen
        /// </summary>
        public ProductCatalogue(string _filename)
        {
            database = new JSONDatabase();
            _fileName = _filename;
            Products = ReadProductsFromFile(_fileName);
            SetCount();
        }

        /// <summary>
        /// En räknare som håller reda på hur många produkter som finns i katalogen, för att kunna tilldela ett unikt produkt-ID
        /// </summary>
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

        /// <summary>
        ///  Kommunicerar med databasen för att spara alla produkter
        /// </summary>
        public void WriteProductsToFile()
        {
            database.WriteDataToFile(Products, _fileName);
        }

        /// <summary>
        /// Kommunicerar med databasen för att läsa in alla produkter och göra om det till Products objekt. 
        /// </summary>
        /// <returns> Returnerar en lista med Products. </returns>
        private List<Product> ReadProductsFromFile(string _fileName)
        {
            if (File.Exists(_fileName))
            {
                string fileContents = File.ReadAllText(_fileName);
                Products = JsonSerializer.Deserialize<List<Product>>(fileContents);
            }
            else Products = new List<Product>();

            return Products;
        }

        /// <summary>
        /// Metod för att se vilka produkter som är slut i lager, returnerar alla produkter som är slut i lager
        /// </summary>
        public List<Product> ProductsOutOfStock()
        {
            IEnumerable<Product> outOfStock = Products.Where(p => p.Stock == 0);
            return outOfStock.ToList();
        }

        /// <summary>
        /// Metod för att lägga till produkt-objekt i katalogen, tar emot namn, pris, antal produkter som ska läggas till, datumet som produkten finns tillgänglig och när den beräknas fyllas på i lager
        /// </summary>
        public void AddProduct(string name, double price, int stock, DateTime firstavailable, DateTime nextStock)
        {
            _currentCode++;
            int code = _currentCode;
            Product newProduct = new Product(code, name, price, stock, firstavailable, nextStock);
            this.Products.Add(newProduct);
            OnProductChange?.Invoke();
        }

        /// <summary>
        /// Metod för att lista alla produkter i katalogen, returnerar en lista med alla produkter
        /// </summary>
        public List<Product> AllProducts()
        {
            return Products;
        }

        /// <summary>
        /// Metod som läser in när en produkt kommer fyllas på, returnerar detta datum
        /// </summary>
        public DateTime NextRestocking()
        {
            return Products.Min(p => p.NextStocking);
        }

        /// <summary>
        /// Metod för att uppdatera en befintlig produkt i katalogen, tar emot produktens ID-kod, namn, pris, antal, när den är tillgänglig, och när den beräknas fyllas på i lager
        /// </summary>
        public void UpdateInformation(int code, string name, double price, int stock, DateTime firstavailable, DateTime nextStock)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Code == code)
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
