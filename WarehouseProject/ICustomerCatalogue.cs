using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public delegate void UpdateCustomerList();

    /// <summary>
    /// Denna interface innehåller de publika metoder och egenskaper som ska finnas i CustomerCatalogue
    /// </summary>
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
