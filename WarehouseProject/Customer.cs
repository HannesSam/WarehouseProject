using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class Customer
    {
        private readonly int _id;
        private string _name;
        private string _phone;
        private string _email;

        public int ID { get { return _id; } }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { _name = value; }
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { _phone = value; }
            }
        }
        public string EMail
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { _email = value; }
            }
        }

        //En konstruktor utan parametrar behövs för JSON Deserialization 
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
