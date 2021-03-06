﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass innehåller en katalog med ordrar. Denna är ständigt uppdaterad och innehåller alla funktioner som 
    /// läser från och lägger till ordrar till databasen. 
    /// </summary>
    public class OrderCatalogue : IOrderCatalogue
    {
        private List<Order> _orders;
        private readonly string _fileName;
        private int _number;
        readonly DateTime _dateToCompare = DateTime.Now - new TimeSpan(24 * 30, 0, 0);

        private ICustomerCatalogue _customerCatalogue;
        private IProductCatalogue _productCatalogue;
        private IDatabase database;

        /// <value>
        /// Orders innehåller den senaste databasen med kunder.
        /// </value>
        public List<Order> Orders { get { return _orders; } set { _orders = value; } }

        public OrderCatalogue(string filename, ICustomerCatalogue customerCatalogue, IProductCatalogue productCatalogue)
        {
            database = new JSONDatabase();
            _fileName = filename;
            _customerCatalogue = customerCatalogue;
            _productCatalogue = productCatalogue;
            Orders = ReadOrdersFromFile(_fileName);
            SetCount();
            WatchNewOrders();
        }

        /// <summary>
        /// SetCount letar upp den största ID:t i den nuvarande listan av orders.
        /// </summary>
        public void SetCount()
        {
            if (_orders.Count == 0)
            {
                _number = 0;
            }
            else
            {
                _number = _orders.Max(o => o.Number);
            }
        }

        /// <summary>
        ///  Kommunicerar med databasen för att spara alla ordrar
        /// </summary>
        public void WriteOrdersToFile()
        {
            database.WriteDataToFile(Orders, _fileName);
        }

        /// <summary>
        /// Kommunicerar med databasen för att läsa in alla produkter och göra om det till Products objekt. Den kopplar sedan 
        /// alla Customer och OrderList objekt till de andra katalogerna. 
        /// </summary>
        /// <returns> Returnerar en lista med ordrar. </returns>
        private List<Order> ReadOrdersFromFile(string fileName)
        {
            var data = database.ReadDataFromFile(fileName);
            List<Order> returnData = data.ToObject<List<Order>>();

            foreach (Order order in returnData)
            {
                var custID = order.Customer.ID;
                order.Customer = _customerCatalogue.Customers.Single(c => c.ID == custID);

                foreach (OrderLine orderLine in order.Items)
                {
                    var prodID = orderLine.Product.Code;
                    orderLine.Product = _productCatalogue.Products.Single(p => p.Code == prodID);
                }
            }

            return returnData;
        }

        /// <summary>
        /// Lägger en listener på mappen neworders som kör ett event varje gång en ny json fil läggs till i mappen.
        /// </summary>
        private void WatchNewOrders()
        {
            FileSystemWatcher fsw = new FileSystemWatcher("./neworders",
           "*.json");
            fsw.Created += Fsw_Created;
            fsw.EnableRaisingEvents = true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            Thread.Sleep(500);
            _orders.AddRange(ReadOrdersFromFile(e.FullPath));
            File.Delete(e.FullPath);
        }

        public void AddOrder(Customer kund, string adress, List<OrderLine> orders)
        {
            if (CheckProductsExists(orders))
            {
                _number++;
                Order newOrder = new Order(_number, kund, DateTime.Now, adress, true, false, false, orders);
                _orders.Add(newOrder);
            }
            else
            {
                throw new ProductNotInCatalogueException("Product does not exist in the catalogue");
            }

        }

        private bool CheckProductsExists(List<OrderLine> orders)
        {
            foreach (var item in orders)
            {
                if (!ProductContains(_productCatalogue.Products, item.Product))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ProductContains(List<Product> plist, Product p)
        {
            foreach (var item in plist)
            {
                if (item == p)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Order> GetDispatchedOrdersFrom(Customer c)
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true && o.Customer == c && o.OrderDate < _dateToCompare);
            return dispatchedOrders.ToList();
        }

        //returns true if the customer has ever placed any orders.
        public bool HasOrder(Customer c)
        {
            foreach (var item in Orders)
            {
                if (item.Customer == c)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Order> GetActiveOrdersFrom(Customer c)
        {
            IEnumerable<Order> pendingOrders = Orders.Where(o => o.Customer == c && (o.Dispatched == false || o.OrderDate > _dateToCompare));
            return pendingOrders.ToList();
        }



        public void DispatchReadyOrders()
        {

            List<Order> orderlist = _orders.Where(o => o.Dispatched == false && o.PaymentCompleted == true && o.Items.All(i => i.Product.Stock >= i.Count) && o.Items.All(i => i.Product.FirstAvailable <= DateTime.Now)).ToList();
            orderlist.Sort((o1, o2) => o1.OrderDate.CompareTo(o2.OrderDate));

            List<Order> finalList = new List<Order>();
            int availableProducts = 0;
            int orderedProducts = 0;
            foreach (var order in orderlist)
            {
                availableProducts = 0;
                orderedProducts = 0;
                foreach (var orderline in order.Items)
                {
                    orderedProducts++;
                    if (orderline.Product.Stock >= orderline.Count)
                    {
                        availableProducts++;
                    }
                }
                if (orderedProducts == availableProducts)
                {
                    UpdateStock(order);
                    finalList.Add(order);
                }
            }
            foreach (var item in Orders)
            {
                foreach (var item1 in finalList)
                {
                    if (item == item1)
                    {
                        item.Dispatched = true;
                    }
                }
            }
        }

        public void UpdateStock(Order o)
        {
            foreach (var item in o.Items)
            {
                foreach (var item1 in _productCatalogue.Products)
                {
                    if (item.Product == item1)
                    {
                        item1.Stock -= item.Count;
                    }
                }
            }
        }
        public List<Order> GetDispatchedOrders()
        {
            IEnumerable<Order> dispatchedOrders = _orders.Where(o => o.Dispatched == true);
            return dispatchedOrders.ToList();
        }

        public List<Order> GetPendingOrders()
        {
            IEnumerable<Order> pendingOrders = _orders.Where(o => o.Dispatched == false);
            return pendingOrders.ToList();
        }
    }
}
