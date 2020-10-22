using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class Order
    {
        private int _number;
        private Customer _customer;
        private DateTime _orderDate;
        private string _deliveryAdress;
        private bool _paymentCompleted;
        private bool _paymentRefunded;
        private bool _dispatched;
        private List<OrderLine> _items;
         
        public int Number
        {
            get { return _number; }
            set
            {
                if (value < 0)
                    throw new IntOrDoubleNegativeException("Number cannot be negative.");
                else
                {
                    _number = value;
                }
            }
        }
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
        public string DeliveryAdress
        {
            get { return _deliveryAdress; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringEmptyOrNullException("Delivery Adress cannot be empty or null.");
                }
                else
                {
                    _deliveryAdress = value;
                }
            }
        }
        public bool PaymentCompleted
        {
            get { return _paymentCompleted; }
            set { _paymentCompleted = value; }
        }
        public bool PaymentRefunded
        {
            get { return _paymentRefunded; }
            set { _paymentRefunded = value; }
        }
        public bool Dispatched
        {
            get { return _dispatched; }
            set { _dispatched = value; }
        }
        public List<OrderLine> Items
        {
            get { }
        }

        public Order()
        {

        }
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
