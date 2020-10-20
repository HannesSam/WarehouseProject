using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class OrderCatalogue
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
