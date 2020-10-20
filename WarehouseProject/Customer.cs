using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Customer
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }

        //En konstruktor utan parametrar behövs för JSON Deserialization 
        public Customer()
        {

        }
        public Customer(int _number, string _name, string _phone, string _eMail)
        {
            this.Number = _number;
            this.Name = _name;
            this.Phone = _phone;
            this.EMail = _eMail;
        }
    }
}
