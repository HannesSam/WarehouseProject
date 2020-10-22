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

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> GetDispatchedOrdersFrom(Customer c)
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true && o.Customer == c);
            return dispatchedOrders.ToList();
        }

        public List<Order> GetActiveOrdersFrom(Customer c)
        {
            IEnumerable<Order> pendingOrders = Orders.Where(o => o.Dispatched == false && o.Customer == c);
            return pendingOrders.ToList();
        }

        //public List<Order> DispatchReadyOrders(ProductCatalogue pc)
        //{
        //    List<Order> dispatchingOrders = new List<Order>();
        //    IEnumerable<Order> readyOrders = Orders.Where(o => o.Dispatched == false && o.PaymentCompleted == true); 

        //    //IEnumerable<Order> readyOrders2 = Orders.Where(o => o.Items.Where(i=> i.Product.Stock > i.Count));
        //    //foreach(Order o in readyOrders)
        //    //{
        //    //    if(o.Items.Count < )
        //    //    o.Dispatched = true;
        //    //    dispatchingOrders.Add(o);
        //    //}
        //    //return dispatchingOrders;
        //}

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
