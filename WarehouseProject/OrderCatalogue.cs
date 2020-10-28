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
            this.customerCatalogue = customerCatalogue;
            this.productCatalogue = productCatalogue;
            _orders = ReadProductsFromFile();
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
            if (CheckProductsExists(orders))
            {
                Number++;
                Order newOrder = new Order(Number, kund, DateTime.Now, adress, true, false, false, orders);
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
                if (!ProductContains(productCatalogue.ProductsProp, item.Product))
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
                foreach (var item1 in productCatalogue.ProductsProp)
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
