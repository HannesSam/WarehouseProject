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
        public Create_order(ProductCatalogue _productCatalogue, CustomerCatalogue _costumerCatalogue, OrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;

            InitializeComponent();
            UpdateList();
        }
        private void UpdateList()
        {
            checkedListBoxProducts.Items.Clear();
            foreach (var item in ProduktKatalog.AllProducts())
            {
                checkedListBoxProducts.Items.Add(item);
            }
            checkedListBoxProducts.DisplayMember = "Name";
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

            foreach (string item in checkedListBoxProducts.CheckedItems.OfType<string>().ToList())
            {
              
                   
                checkedListBoxOrderLine.Items.Add(item + " " + "(" + count +")");
                   

                
            }


        }

        private void textBoxQuantity_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
