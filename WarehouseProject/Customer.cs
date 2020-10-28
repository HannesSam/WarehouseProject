using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    /// <summary>
    /// Customer klassen innehåller all information som systemet behöver för en kund.
    /// </summary>
    public class Customer
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _email;

        /// <value> ID är den unika siffra som varje kund har </value>
        public int ID { get { return _id; } set { _id = value; } }

        /// <value> Namn är kundens namn </value>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new StringEmptyOrNullException("Name cannot be null"); }
                else { _name = value; } 
            }
        }

        /// <value> Phone är kundens telefonnummer </value>
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new StringEmptyOrNullException("Phone cannot be null"); } else { _phone = value; }
            }
        }

        /// <value> EMail är kundens mail </value>
        public string EMail
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new StringEmptyOrNullException("EMail cannot be null"); } else { _email = value; }
            }
        }

        /// <summary>
        /// En konstruktor utan parametrar för att JSON Deserilazation ska funka.
        /// </summary>
        public Customer()
        {

        }
        public Customer(int id, string name, string phone, string eMail)
        {
            _id = id;
            _name = name;
            _phone = phone;
            _email = eMail;
        }
    }
}
