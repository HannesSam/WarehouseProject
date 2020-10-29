using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace WarehouseProject
{
    /// <summary>
    /// Huvudklassen för produktkatalogen, innehåller alla funktioner för läsa och skriva till datbasen, lägga till och uppdatera produkter
    /// </summary>
    public class ProductCatalogue : IProductCatalogue
    {
        private List<Product> _products;
        private string _filename;
        private int _currentCode;


        public List<Product> Products { get { return _products; } set { _products = value; } }

        public delegate void UpdateProductList();

        public event UpdateProductList OnProductChange;

        /// <summary>
        /// Konstruktor för att instansiera och skapa ett produkt-objekt i katalogen.
        /// </summary>
        /// <param name="_filename">En sträng.</param>
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
        /// Metod för att skriva befintlig produktkatalog till textfil.
        /// </summary>
        public void WriteProductsToFile()
        {
            database.WriteDataToFile(Products, _fileName);
        }

        /// <summary>
        /// Metod för att läsa in produktkatalog från textfil.
        /// </summary>
        /// <returns>Lista med produkt-objekt.</returns>
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
        /// Metod för att se vilka produkter som är slut i lager.
        /// </summary>
        /// <returns>Lista med produkter.</returns>
        public List<Product> ProductsOutOfStock()
        {
            IEnumerable<Product> outOfStock = Products.Where(p => p.Stock == 0);
            return outOfStock.ToList();
        }

        /// <summary>
        /// Metod för att lägga till produkt-objekt i katalogen.
        /// </summary>
        /// <param name="name">Produktens namn</param>
        /// <param name="price">Produktens pris</param>
        /// <param name="stock">Antal av produkter som ska läggas till</param>
        /// <param name="firstavailable">Datumet som produkten finns tillgänglig</param>
        /// <param name="nextStock">Nästkommande datum som produkten kommer fyllas på</param>
        public void AddProduct(string name, double price, int stock, DateTime firstavailable, DateTime nextStock)
        {
            _currentCode++;
            int code = _currentCode;
            Product newProduct = new Product(code, name, price, stock, firstavailable, nextStock);
            this.Products.Add(newProduct);
            OnProductChange?.Invoke();
        }

        /// <summary>
        /// Metod för att lista alla produkter i katalogen.
        /// </summary>
        /// <returns>En lista med produkter.</returns>
        public List<Product> AllProducts()
        {
            return Products;
        }

        /// <summary>
        /// Metod som läser in när en produkt kommer fyllas på.
        /// </summary>
        /// <returns>Datum.</returns>
        public DateTime NextRestocking()
        {
            return Products.Min(p => p.NextStocking);
        }

        /// <summary>
        /// Metod för att uppdatera en befintlig produkt i katalogen.
        /// </summary>
        /// <param name="code">Produktkod</param>
        /// <param name="name">Produktens namn</param>
        /// <param name="price">Produktens pris</param>
        /// <param name="stock">Antal av produkten som ska läggas in</param>
        /// <param name="firstavailable">Datum som produkten fylls på</param>
        /// <param name="nextStock">Nästa datum som produkten ska fyllas på</param>
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
