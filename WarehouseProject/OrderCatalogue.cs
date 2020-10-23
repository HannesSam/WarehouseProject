﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Diagnostics.PerformanceData;

namespace WarehouseProject
{
    public class OrderCatalogue
    {
        private List<Order> _orders;
        private string filename;
        public int Number;

        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public OrderCatalogue(string _filename)
        {
            this.filename = _filename;
            _orders = ReadProductsFromFile();
            SetCount();
        }

        public void SetCount()
        {
            if (_orders.Count==0)
            {
                Number = 0;
            }
            else
            {
                Number = _orders.Max(o => o.Number);
            }
        }
        public void WriteProductsToFile()
        {
            string contents = JsonSerializer.Serialize(_orders);
            File.WriteAllText(filename, contents);
        }

        private List<Order> ReadProductsFromFile()
        {
            if (File.Exists(filename))
            {
                string fileContents = File.ReadAllText(filename);
                _orders = JsonSerializer.Deserialize<List<Order>>(fileContents);
            }
            else _orders = new List<Order>();


            return _orders;
        }

        public void AddOrder(Customer kund, string adress, List<OrderLine> orders)
        {
            Number++;
            Order newOrder = new Order(Number, kund, DateTime.Now, adress, true, false, false, orders);
            _orders.Add(newOrder);
        }

        public List<Order> GetDispatchedOrdersFrom(Customer c)
        {
            IEnumerable<Order> dispatchedOrders = _orders.Where(o => o.Dispatched == true && o.Customer == c);
            return dispatchedOrders.ToList();
        }

        public List<Order> GetActiveOrdersFrom(Customer c)
        {
            IEnumerable<Order> pendingOrders = _orders.Where(o => o.Dispatched == false && o.Customer == c);
            return pendingOrders.ToList();
        }

        public List<Order> DispatchReadyOrders(ProductCatalogue pc)
        {
            IEnumerable<Order> readyOrders = _orders.Where(o => o.Dispatched == false && o.PaymentCompleted == true && o.Items.All(i => i.Product.Stock >= i.Count));

            return readyOrders.ToList();
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
