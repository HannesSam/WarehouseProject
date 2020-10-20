using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class OrderCatalogue
    {
        private List<Order> Orders;

        public OrderCatalogue(List<Order> _orders)
        {
            this.Orders = _orders;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        //public IEnumerable<Order> GetDispatchedOrdersFrom(Customer person)
        //{
            
        //}

        //public IEnumerable<Order> GetActiveOrdersFrom(Customer person)
        //{

        //}

        //public IEnumerable<Order> DispatchReadyOrders()
        //{

        //}

        //public IEnumerable<Order> GetDispatchedOrders()
        //{

        //}

        //public IEnumerable<Order> GetPendingOrders()
        //{

        //}
    }
}
