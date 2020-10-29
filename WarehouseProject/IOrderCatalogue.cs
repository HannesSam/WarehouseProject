using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    /// <summary>
    /// Denna interface innehåller de publika metoder och egenskaper som ska finnas i OrderCatalogue
    /// </summary>
    public interface IOrderCatalogue
    {
        List<Order> Orders { get; set; }
        void SetCount();
        void WriteOrdersToFile();
        void AddOrder(Customer kund, string adress, List<OrderLine> orders);
        List<Order> GetDispatchedOrdersFrom(Customer c);
        bool HasOrder(Customer c);
        List<Order> GetActiveOrdersFrom(Customer c);
        void DispatchReadyOrders();
        void UpdateStock(Order o);
        List<Order> GetDispatchedOrders();
        List<Order> GetPendingOrders();
    }
}
