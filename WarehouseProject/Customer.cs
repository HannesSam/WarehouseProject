﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _email;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new StringEmptyOrNullException("Name cannot be null"); }
                else { _name = value; } 
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new StringEmptyOrNullException("Phone cannot be null"); } else { _phone = value; }
            }
        }
        public string EMail
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new StringEmptyOrNullException("EMail cannot be null"); } else { _email = value; }
            }
        }

        //En konstruktor utan parametrar behövs för JSON Deserialization 
        public Customer()
        {

        }
        public Customer(int id, string name, string phone, string eMail)
        {
            ID = id;
            Name = name;
            Phone = phone;
            EMail = eMail;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
