using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarehouseProject
{
    public partial class Create_order : Form
    {

        public ProductCatalogue ProduktKatalog;
        public CustomerCatalogue KundKatalog;
        public OrderCatalogue OrderKatalog;
        public List<OrderLine> ProduktLista;
        public Create_order(ProductCatalogue _productCatalogue, CustomerCatalogue _costumerCatalogue, OrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;

            ProduktLista = new List<OrderLine>();
            InitializeComponent();
            UpdateList();
        }
        private void UpdateList()
        {
            checkedListBoxProducts.Items.Clear();
            Customer.Items.Clear();

            foreach (var item in KundKatalog.Customers)
            {
                Customer.Items.Add(item);
            }
             Customer.DisplayMember = "Name";

            foreach (var item in ProduktKatalog.AllProducts())
            {
                checkedListBoxProducts.Items.Add(item);
            }
            checkedListBoxProducts.DisplayMember = "Name" + " " +  "Stock";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void Create_order_Load(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var f = new Startsida(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        private void checkedListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            decimal decimalcount = textBoxQuantity.Value;
            int count = Convert.ToInt32(decimalcount);

            foreach (var item in checkedListBoxProducts.CheckedItems.OfType<Product>().ToList())
            {
                if (Contains(item))
                {
                    foreach (var order in checkedListBoxOrderLine.Items.OfType<OrderLine>().ToList())
                    {
                        if (order.Product.Name == item.Name)
                        {
                            order.Count += count;
                            UpdateSelectedList();
                        }
                    }
                }
                else
                {
                    OrderLine vara = new OrderLine(item, count);
                    checkedListBoxOrderLine.Items.Add(vara);
                }
            }

        }

        private void UpdateSelectedList()
        {
            List<OrderLine> update = checkedListBoxOrderLine.Items.OfType<OrderLine>().ToList();

            checkedListBoxOrderLine.Items.Clear();
            foreach (var item in update)
            {
                checkedListBoxOrderLine.Items.Add(item);
            }

        }
        private bool Contains(Product vara)
        {
            foreach (var item in checkedListBoxOrderLine.Items.OfType<OrderLine>().ToList())
            {
                if (item.Product.Name == vara.Name)
                {
                    return true;
                }
            }
            return false;
        }
        private void textBoxQuantity_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {

            for (int i = checkedListBoxOrderLine.Items.Count - 1; i >= 0; i--)
            {
                
                if (checkedListBoxOrderLine.GetItemChecked(i))
                {
                    checkedListBoxOrderLine.Items.Remove(checkedListBoxOrderLine.Items[i]);
                }
            }
        }

        private void Customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Customer customerreference = (Customer)Customer.SelectedItem;
            string adress = textBoxdelivery.SelectedText;
            List<OrderLine> produktlista = new List<OrderLine>();
        
                foreach (object item in checkedListBoxOrderLine.Items)
                 {
                checkedListBoxOrderLine.Items.Add(produktlista);
                 }
            
            OrderKatalog.AddOrder(customerreference,adress,produktlista);
        }
    }
}
