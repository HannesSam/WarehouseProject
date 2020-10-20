using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Order
    {
        int Number { get; set; }
        Customer Customer { get; set; }
        DateTime OrderDate { get; set; }
        string DeliveryAdress { get; set; }
        bool PaymentCompleted { get; set; }
        bool PaymentRefunded { get; set; }
        bool Dispatched { get; set; }
        List<OrderLine> Items { get; set; }

        public Order(int _number, Customer _customer, DateTime _orderDate, string _deliveryAdress, bool _paymentCompleted, bool _paymentRefunded, bool _dispatched, List<OrderLine> _items)
        {
            this.Number = _number;
            this.Customer = _customer;
            this.OrderDate = _orderDate;
            this.DeliveryAdress = _deliveryAdress;
            this.PaymentCompleted = _paymentCompleted;
            this.PaymentRefunded = _paymentRefunded;
            this.Dispatched = _dispatched;
        }

    }
}
