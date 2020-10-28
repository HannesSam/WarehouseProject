using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Diagnostics.PerformanceData;
using System.Threading;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass innehåller en katalog med ordrar. Denna är ständigt uppdaterad och innehåller alla funktioner som 
    /// läser från och lägger till ordrar till databasen. 
    /// </summary>
    public class OrderCatalogue
    {
        private List<Order> _orders;
        private readonly string _filename;
        public int _number;
        readonly DateTime _dateToCompare = DateTime.Now - new TimeSpan(24 * 30, 0, 0);

        private CustomerCatalogue _customerCatalogue;
        private ProductCatalogue _productCatalogue;

        public List<Order> Orders { get { return _orders; } set { _orders = value; } }

        public OrderCatalogue()
        {

        }
        public OrderCatalogue(string filename, CustomerCatalogue customerCatalogue, ProductCatalogue productCatalogue)
        {
            _filename = filename;
            _customerCatalogue = customerCatalogue;
            _productCatalogue = productCatalogue;
            _orders = ReadProductsFromFile(filename);
            SetCount();
            WatchNewOrders();
        }

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
        public void WriteProductsToFile()
        {
            string contents = JsonSerializer.Serialize(_orders);
            File.WriteAllText(_filename, contents);
        }

        private List<Order> ReadProductsFromFile(string filename)
        {
            List<Order> tempOrderList = new List<Order>();
            if (File.Exists(filename))
            {
                string fileContents = File.ReadAllText(filename);
                tempOrderList = JsonSerializer.Deserialize<List<Order>>(fileContents);
            }

            foreach (Order order in tempOrderList)
            {
                var custID = order.Customer.ID;
                order.Customer = _customerCatalogue.Customers.Single(c => c.ID == custID);

                foreach (OrderLine orderLine in order.Items)
                {
                    var prodID = orderLine.Product.Code;
                    orderLine.Product = _productCatalogue.ProductsProp.Single(p => p.Code == prodID);
                }
            }

            return tempOrderList;
        }

        private void WatchNewOrders()
        {
            FileSystemWatcher fsw = new FileSystemWatcher("./neworders",
           "*.json");
            fsw.Created += Fsw_Created;
            fsw.EnableRaisingEvents = true;
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            Thread.Sleep(500);
            _orders.AddRange(ReadProductsFromFile(e.FullPath));
            File.Delete(e.FullPath);
        }

        public void AddOrder(Customer kund, string adress, List<OrderLine> orders)
        {
            _number++;
            Order newOrder = new Order(_number, kund, DateTime.Now, adress, true, false, false, orders);
            _orders.Add(newOrder);
        }

        public List<Order> GetDispatchedOrdersFrom(Customer c)
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true && o.Customer == c && o.OrderDate < _dateToCompare);
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
            IEnumerable<Order> pendingOrders = Orders.Where(o => o.Customer == c && (o.Dispatched == false || o.OrderDate > _dateToCompare));
            return pendingOrders.ToList();
        }


        //Den här metoden tar 
        public void DispatchReadyOrders()
        {
            IEnumerable<Order> readyOrders = _orders.Where(o => o.Dispatched == false && o.PaymentCompleted == true && o.Items.All(i => i.Product.Stock >= i.Count));
            List<Order> orderlist = readyOrders.ToList();
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

        public void UpdateStock (Order o )
        {
            foreach (var item in o.Items)
            {
                foreach (var item1 in _productCatalogue.ProductsProp)
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
