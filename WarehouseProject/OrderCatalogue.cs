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
        private List<Order> _orders;
        private string filename;
        public int Number;
        DateTime dateToCompare = DateTime.Now - new TimeSpan(24 * 30, 0, 0);

        private CustomerCatalogue customerCatalogue;
        private ProductCatalogue productCatalogue;

        public List<Order> Orders { get { return _orders; } set { _orders = value; } }

        public OrderCatalogue()
        {

        }
        public OrderCatalogue(string _filename, CustomerCatalogue customerCatalogue, ProductCatalogue productCatalogue)
        {
            this.filename = _filename;
            _orders = ReadProductsFromFile();
            this.customerCatalogue = customerCatalogue;
            this.productCatalogue = productCatalogue;
            SetCount();
        }

        public void SetCount()
        {
            if (_orders.Count == 0)
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

            foreach (Order order in Orders)
            {
                var custID = order.Customer.ID;
                order.Customer = customerCatalogue.Customers.Single(c => c.ID == custID);

                foreach (OrderLine orderLine in order.Items)
                {
                    var prodID = orderLine.Product.Code;
                    orderLine.Product = productCatalogue.ProductsProp.Single(p => p.Code == prodID);
                }
            }

            return Orders;
        }

        public void AddOrder(Customer kund, string adress, List<OrderLine> orders)
        {
            Number++;
            Order newOrder = new Order(Number, kund, DateTime.Now, adress, true, false, false, orders);
            _orders.Add(newOrder);
        }

        public List<Order> GetDispatchedOrdersFrom(Customer c)
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true && o.Customer == c);
            return dispatchedOrders.ToList();
        }

        //returns true if the customer has ever placed any orders.
        public bool HasOrder (Customer c)
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
            IEnumerable<Order> pendingOrders = Orders.Where(o => o.Dispatched == false && o.Customer == c);
            return pendingOrders.ToList();
        }

        public void DispatchReadyOrders()
        {
            IEnumerable<Order> readyOrders = _orders.Where(o => o.Dispatched == false && o.PaymentCompleted == true && o.Items.All(i => i.Product.Stock >= i.Count));
            List<Order> orderlist = readyOrders.ToList();
            foreach (var item in Orders)
            {
                foreach (var item1 in orderlist)
                {
                    if (item == item1)
                    {
                        item.Dispatched = true;
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
