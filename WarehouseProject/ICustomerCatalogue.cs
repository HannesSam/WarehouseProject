using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public delegate void UpdateCustomerList();
    public interface ICustomerCatalogue
    {

        List<Customer> Customers { get; set; }

        event UpdateCustomerList OnCustomerChange;
        void SetID();
        void WriteCustomersToFile();
        void AddCustomer(string name, string phone, string email);
        void UpdateCustomer(int id, string name, string phone, string email);


    }
}
