using System;
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
        private List<Order> Orders;
        private string filename;
        public int Number;
        DateTime dateToCompare = DateTime.Now - new TimeSpan(24*30, 0, 0);

        public OrderCatalogue(string _filename)
        {
            this.filename = _filename;
            Orders = ReadProductsFromFile();
            SetCount();
        }

        public void SetCount()
        {
            if (Orders.Count==0)
            {
                Number = 0;
            }
            else
            {
                Number = Orders.Max(o => o.Number);
            }
        }
        public void WriteProductsToFile()
        {
            string contents = JsonSerializer.Serialize(Orders);
            File.WriteAllText(filename, contents);
        }

        private List<Order> ReadProductsFromFile()
        {
            if (File.Exists(filename))
            {
                string fileContents = File.ReadAllText(filename);
                Orders = JsonSerializer.Deserialize<List<Order>>(fileContents);
            }
            else Orders = new List<Order>();

            return Orders;
        }

        public void AddOrder(Customer kund, string adress, List<OrderLine> orders)
        {
            Number++;
            Order newOrder = new Order(Number, kund, DateTime.Now, adress, false, false, false, orders);
            Orders.Add(newOrder);
        }

        public List<Order> GetDispatchedOrdersFrom(Customer c)
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true && o.Customer == c && o.OrderDate < dateToCompare);
            return dispatchedOrders.ToList();
        }

        public List<Order> GetActiveOrdersFrom(Customer c)
        {
            IEnumerable<Order> pendingOrders = Orders.Where(o => o.Customer == c && (o.Dispatched == false || o.OrderDate > dateToCompare));
            return pendingOrders.ToList();
        }

        public List<Order> DispatchReadyOrders(ProductCatalogue pc)
        {
            IEnumerable<Order> readyOrders = Orders.Where(o => o.Dispatched == false && o.PaymentCompleted == true && o.Items.All(i => i.Product.Stock >= i.Count));

            return readyOrders.ToList();
        }

        public List<Order> GetDispatchedOrders()
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true);
            return dispatchedOrders.ToList();
        }

        public List<Order> GetPendingOrders()
        {
            IEnumerable<Order> pendingOrders = Orders.Where(o => o.Dispatched == false);
            return pendingOrders.ToList();
        }
    }
}
