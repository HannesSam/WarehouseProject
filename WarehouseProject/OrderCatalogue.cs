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

        //public List<Order> GetDispatchedOrdersFrom()
        //{
            
        //}

        //public List<Order> GetActiveOrdersFrom()
        //{

        //}

        //public List<Order> DispatchReadyOrders()
        //{

        //}

        //public List<Order> GetDispatchedOrders()
        //{

        //}

        //public List<Order> GetPendingOrders()
        //{

        //}
    }
}
