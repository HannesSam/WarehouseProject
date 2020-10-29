using System;
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

            Warehouse warehouse = new Warehouse("customers.json", "products.json", "orders.json");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Startsida(warehouse._productCatalogue, warehouse._customerCatalogue, warehouse._orderCatalogue));
            warehouse.EndWarehouse();
        }
    }
}
