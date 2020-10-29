using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseProject
{
    /// <summary>
    /// Den här klassen agerar som en startsida och tillåter användaren att navigera sig mellan de andra formsen.
    /// </summary>
    public partial class Startsida : Form
    {
        public ProductCatalogue ProduktKatalog;
        public CustomerCatalogue KundKatalog;
        public OrderCatalogue OrderKatalog;
        public Startsida(ProductCatalogue _productCatalogue, CustomerCatalogue _costumerCatalogue, OrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;
            InitializeComponent();
        }

        /// <summary>
        /// Denna knapp tar användaren vidare till Order Management Formet.
        /// </summary>
        private void OrderManagement_Click(object sender, EventArgs e)
        {
            var f = new Order_management(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Denna knapp tar användaren vidare till Product Management Formet.
        /// </summary>
        private void ProductManagement_Click(object sender, EventArgs e)
        {
            var f = new Product_management(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Denna knapp tar användaren vidare till Customer Management Formet.
        /// </summary>
        private void CustomerManagement_Click(object sender, EventArgs e)
        {
            var f = new Customer_management(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Denna knapp tar användaren vidare till Create order Formet.
        /// </summary>
        private void NewOrder_Click(object sender, EventArgs e)
        {
            var f = new Create_order(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Denna knapp terminerar programmet.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
