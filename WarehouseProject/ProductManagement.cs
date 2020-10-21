using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseProject
{
    public partial class Product_management : Form
    {
        public ProductCatalogue ProduktKatalog;
        public CustomerCatalogue KundKatalog;
        public OrderCatalogue OrderKatalog;
        public Product_management(ProductCatalogue _productCatalogue, CustomerCatalogue _costumerCatalogue, OrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;
            InitializeComponent();
            UpdateList();
            productListBox.SelectedIndexChanged += productListBox_SelectedIndexChanged;
        }

        private void Product_management_Load(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var f = new Startsida(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        //Visar alla produkter från ProduktKatalogen till productListBox.
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            foreach (var item in ProduktKatalog.AllProducts())
            {
                productListBox.Items.Add(item);
            }
            productListBox.DisplayMember = "Name";
        }

        //När man ändrar den valda produkten i listboxen så ändras värdena i textboxarna så att man kan se alla attribut hos produkten.
        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product pro = (Product) productListBox.SelectedItem;
            codeTextBox.Text = pro.Code.ToString();
            nameTextBox.Text = pro.Name;
            priceTextBox.Text = pro.Price.ToString();
            stockTextBox.Text = pro.Stock.ToString();
            firstAvailableTextBox.Text = pro.FirstAvailable.ToString();
            nextStockingTextBox.Text = pro.NextStocking.ToString();
        }

        //updaterar Listboxen
        private void UpdateList()
        {
            productListBox.Items.Clear();
            foreach (var item in ProduktKatalog.AllProducts())
            {
                productListBox.Items.Add(item);
            }
            productListBox.DisplayMember = "Name";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Ger productListbox alla produkter där Stock = 0.
        private void ShowOutOfStockButton_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            foreach (var item in ProduktKatalog.ProductsOutOfStock())
            {
                productListBox.Items.Add(item);
            }
            productListBox.DisplayMember = "Name";
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Lägger till en ny produkt utifrån informationen i TextBoxarna. 
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(codeTextBox.Text);
            string name = nameTextBox.Text;
            double price = double.Parse(priceTextBox.Text);
            int stock = int.Parse(stockTextBox.Text);
            DateTime firstavailable = DateTime.Parse(firstAvailableTextBox.Text);
            DateTime nextstock = DateTime.Parse(nextStockingTextBox.Text);

            Product newProduct = new Product(code, name, price, stock, firstavailable, nextstock);
            ProduktKatalog.AddProduct(newProduct);
            UpdateList();
        }

        //Updaterar den produkten som är vald i listboxen utifrån informationen i textboxarna.
        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            //Ska code kunna ändras?
            int code = int.Parse(codeTextBox.Text);
            string name = nameTextBox.Text;
            double price = double.Parse(priceTextBox.Text);
            int stock = int.Parse(stockTextBox.Text);
            DateTime firstavailable = DateTime.Parse(firstAvailableTextBox.Text);
            DateTime nextstock = DateTime.Parse(nextStockingTextBox.Text);

            //Detta bör ske i ProductCatalogue / i Product klassen.
            Product pro = (Product)productListBox.SelectedItem;
            pro.Code = code;
            pro.Name = name;
            pro.Price = price;
            pro.Stock = stock;
            pro.FirstAvailable = firstavailable;
            pro.NextStocking = nextstock;

            UpdateList();
        }

        private void ClosestRestockingButton_Click(object sender, EventArgs e)
        {
            closestRestockingTextBox.Text = ProduktKatalog.NextRestocking().ToString();
        }
    }
}
