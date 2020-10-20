using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class Order
    {
        public int Number { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAdress { get; set; }
        public bool PaymentCompleted { get; set; }
        public bool PaymentRefunded { get; set; }
        public bool Dispatched { get; set; }
        public List<OrderLine> Items { get; set; }

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
