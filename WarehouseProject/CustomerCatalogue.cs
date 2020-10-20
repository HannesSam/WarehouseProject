using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;
using System.Text.Json;

namespace WarehouseProject
{
    public class CustomerCatalogue
    {
        string filename = "customers.json";
        public List<Customer> Customers = new List<Customer>();

        //Read Customer list from json on startup

        public void AddTestData()
        {
            Customer test1 = new Customer(1, "Hannes", "072-23423523", "Hannes@warehouse.cool");
            Customer test2 = new Customer(2, "Axel", "072-23423523", "Axel@warehouse.cool");
            Customer test3 = new Customer(3, "Christoffer", "072-23423523", "Christoffer@warehouse.cool");
            Customer test4 = new Customer(4, "JeppeBoi", "072-23423523", "JeppeBoi@warehouse.cool");
            Customers.Add(test1);
            Customers.Add(test2);
            Customers.Add(test3);
            Customers.Add(test4);
        }
        public void WriteProductsToFile()
        {
            string contents = JsonSerializer.Serialize(Customers);
            File.WriteAllText(filename, contents);
        }

        public void ReadProductsFromFile()
        {
            if (File.Exists(filename))
            {
                string fileContents = File.ReadAllText(filename);
                Customers = JsonSerializer.Deserialize<List<Customer>>(fileContents);
            }
            else Customers = new List<Customer>();

            Console.ReadLine();
        }

        public void AddCustomer()
        {

        }

        //Add Customer
        //Update Customer

    }
}
