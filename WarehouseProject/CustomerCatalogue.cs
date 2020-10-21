using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace WarehouseProject
{
    public class CustomerCatalogue
    {
        private string Filename;
        public int currentID;
        private List<Customer> Customers { get; set; }

        //Read Customer list from json on startup
        public CustomerCatalogue(string _filename)
        {
            this.Filename = _filename;
            Customers = ReadProductsFromFile();

            //Hittar det nuvarande största ID:t i listan över kunder och sparar det. 
            //currentID = Customers.Max(c => c.ID);
        }

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
            File.WriteAllText(Filename, contents);
        }

        private List<Customer> ReadProductsFromFile()
        {
            if (File.Exists(Filename))
            {
                string fileContents = File.ReadAllText(Filename);
                Customers = JsonSerializer.Deserialize<List<Customer>>(fileContents);
            }
            else Customers = new List<Customer>();

            return Customers;
        }

        public void AddCustomer(string name, string phone, string email)
        {
            try
            {
                currentID++;
                Customer customer = new Customer(currentID, name, phone, email);
                Customers.Add(customer);
            }
            catch (Exception ex)
            {
                //Här ska ett error returnereas till the gui
            }
        }

        public void UpdateCustomer(int number)
        {
            Customer customer = Customers.Single(c => c.ID == number);
            //Här ska customer uppdateras med alla nya värden
            //Men först måste man implementera checkar i customer klassen som kollar att alla värden 
            //Är giltiga. 
            
        }

        //Add Customer
        //Update Customer

    }
}
