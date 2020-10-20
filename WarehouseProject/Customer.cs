using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Customer
    {
        int Number { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        string EMail { get; set; }

        public Customer(int _number, string _name, string _phone, string _eMail)
        {
            this.Number = _number;
            this.Name = _name;
            this.Phone = _phone;
            this.EMail = _eMail;
        }
    }
}
