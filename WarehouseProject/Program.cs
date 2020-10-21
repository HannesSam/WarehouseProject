using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Warehouse warehouse = new Warehouse();
            warehouse.StartWarehouse("customers.json", "products.json", "orders.json");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Lite jobbigt att skicka 3 kataloger till startsidan istället för ett warehouse, men det underlättar när man ska bläddra mellan sidor. 
            Application.Run(new Startsida(warehouse._productCatalogue, warehouse._customerCatalogue, warehouse._orderCatalogue));
            warehouse.EndWarehouse();
        }
    }
}
