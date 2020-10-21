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

        private void Startsida_Load(object sender, EventArgs e)
        {

        }

        private void OrderManagement_Click(object sender, EventArgs e)
        {
            var f = new Order_management(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        private void ProductManagement_Click(object sender, EventArgs e)
        {
            var f = new Product_management(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        private void CustomerManagement_Click(object sender, EventArgs e)
        {
            var f = new Customer_management(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            var f = new Create_order(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ProduktKatalog.WriteProductsToFile();
            KundKatalog.WriteProductsToFile();
            OrderKatalog.WriteProductsToFile();
            this.Close();
        }
    }
}
