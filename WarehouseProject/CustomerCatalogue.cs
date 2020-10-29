using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass innehåller en katalog med kunder. Denna är ständigt uppdaterad och innehåller alla funktioner som 
    /// läser från och lägger till kunder till databasen. 
    /// </summary>
    public class CustomerCatalogue : ICustomerCatalogue
    {
        private readonly string _filename;
        private int _currentID;
        private List<Customer> _customers;

        /// <value>
        /// Customers innehåller den senaste databasen med kunder.
        /// </value>
        public List<Customer> Customers { get { return _customers; } set { _customers = value; } }

        /// <summary>
        /// Detta event och delegat definerar ett event som körs varje gång en kund uppdateras eller läggs till. 
        /// </summary>
        public event UpdateCustomerList OnCustomerChange;

        public CustomerCatalogue(string filename)
        {
            _filename = filename;
            Customers = ReadCustomersFromFile();
            SetID();
        }

        /// <summary>
        /// SetID letar upp den största ID:t i den nuvarande listan av kunder.
        /// </summary>
        public void SetID()
        {
            if (_customers.Count == 0)
            {
                _currentID = 0;
            }
            else
            {
                _currentID = _customers.Max(c => c.ID);
            }
        }

        /// <summary>
        /// Sparar ner det nuvarande innehållet i listan med kunder till en databas vilket är en JSON fil. 
        /// </summary>
        public void WriteCustomersToFile()
        {
            string contents = JsonSerializer.Serialize(Customers);
            File.WriteAllText(_filename, contents);
        }

        /// <summary>
        /// Läser från databasen och lägger in alla kunder i listan om databasen existerar. 
        /// </summary>
        /// <returns> Returnerar en lista med kunder. </returns>
        private List<Customer> ReadCustomersFromFile()
        {
            if (File.Exists(_filename))
            {
                string fileContents = File.ReadAllText(_filename);
                Customers = JsonSerializer.Deserialize<List<Customer>>(fileContents);
            }
            else Customers = new List<Customer>();

            return Customers;
        }

        /// <summary>
        /// Tar in alla nödvändiga varaiabler för att skapa en ny kund och lägger sedan till denna till listan med kunder.
        /// Kallar även på eventet som visar att listan med kunder har ändrats. 
        /// </summary>
        public void AddCustomer(string name, string phone, string email)
        {
            _currentID++;
            Customer customer = new Customer();
            customer.ID = _currentID;
            customer.Name = name;
            customer.Phone = phone;
            customer.EMail = email;
            Customers.Add(customer);

            //Kollar att delegaten inte är null kör annars eventet
            OnCustomerChange?.Invoke();
        }

        /// <summary>
        /// Tar in alla parametrar för att uppdatera en kund och sparar den uppdaterade informationen. 
        /// Kallar även på ett event för att visa att listan med kunder har ändrats.
        /// </summary>
        public void UpdateCustomer(int id, string name, string phone, string email)
        {
            Customer customer = Customers.Single(c => c.ID == id);
            customer.Name = name;
            customer.Phone = phone;
            customer.EMail = email;

            //Kollar att delegaten inte är null kör annars eventet
            OnCustomerChange?.Invoke();
        }

    }
}
