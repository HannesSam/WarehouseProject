using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Linq;

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
            //Number = Orders.Max(o => o.Number);
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
        public void WriteProductsToFile()
        {
            string content = JsonSerializer.Serialize(Orders);
            File.WriteAllText(filename, content);
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
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
