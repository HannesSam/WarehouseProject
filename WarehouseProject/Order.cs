using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    /// <summary>
    /// Class som innehåller all information och funktionalitet som behövs för en order.
    /// </summary>
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

        /// <value> Number är kundens unika ID. Borde nog heta ID för att vara konsekvent med 
        /// de andra klasserna men enligt uppgiften ska det heta Number </value>
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

        /// <value> Customer är den kund som är knuten till ordern </value>
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        /// <value> OrderDate är det datum som ordern lades </value>
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        /// <value> DeliveryAdress är den adress som ordern ska skickas till </value>
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

        /// <value> PaymentCompleted är true om ordern är betalad </value>
        public bool PaymentCompleted
        {
            get { return _paymentCompleted; }
            set { _paymentCompleted = value; }
        }

        /// <value> PaymentRefunded är true om pengarna för ordern har betalats tillbaka </value>
        public bool PaymentRefunded
        {
            get { return _paymentRefunded; }
            set { _paymentRefunded = value; }
        }

        /// <value> Dispatched är true om ordern har skickats </value>
        public bool Dispatched
        {
            get { return _dispatched; }
            set { _dispatched = value; }
        }

        /// <value> Denna lista innehåller orderLines vilket är de objekt som håller koll på
        /// vad som har beställts och hur många av en vara som har beställts för varje order </value>
        public List<OrderLine> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// En konstruktor utan parametrar för att JSON Deserialization ska funka.
        /// </summary>
        public Order()
        {

        }

        public Order(int number, Customer customer, DateTime orderDate, string deliveryAdress, bool paymentCompleted, bool paymentRefunded, bool dispatched, List<OrderLine> items)
        {
            _number = number;
            _customer = customer;
            _orderDate = orderDate;
            _deliveryAdress = deliveryAdress;
            _paymentCompleted = paymentCompleted;
            _paymentRefunded = paymentRefunded;
            _dispatched = dispatched;
            _items = items;
        }

        /// <summary>
        /// Returnerar ett korrekt formaterat namn för en order
        /// </summary>
        public override string ToString()
        {
            return "Ordernumber : " + Number.ToString() + " Customer : " + Customer.Name;
        }
    }
}
