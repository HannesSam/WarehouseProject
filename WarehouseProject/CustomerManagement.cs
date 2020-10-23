using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseProject
{
    public partial class Customer_management : Form
    {
//        listStrings.OnItemAdded += HandleOnElementAdded ;
//}
//    private void HandleOnElementAdded(int itemIndex, string item)
//    {
//        LSTItems.Items.Insert(itemIndex, item);
//    }

    public ProductCatalogue ProduktKatalog;
        public CustomerCatalogue KundKatalog;
        public OrderCatalogue OrderKatalog;
        public Customer_management(ProductCatalogue _productCatalogue, CustomerCatalogue _costumerCatalogue, OrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;
            InitializeComponent();
            UpdateList();
            customerListBox.SelectedIndexChanged += CustomerListBoxChanged;

            KundKatalog.OnCustomerChange += UpdateList;
        }

        private void Customer_management_Load(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var f = new Startsida(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        private void UpdateList()
        {
            customerListBox.Items.Clear();
            foreach (var item in KundKatalog.Customers)
            {
                customerListBox.Items.Add(item);
            }
            customerListBox.DisplayMember = "Name";
        }
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            customerListBox.Items.Clear();
            foreach (var item in KundKatalog.Customers)
            {
                customerListBox.Items.Add(item);
            }
            customerListBox.DisplayMember = "Name";
        }
        private void CustomerListBoxChanged(object sender, EventArgs e)
        {
            Customer cus = (Customer)customerListBox.SelectedItem;

            nameTextBox.Text = cus.Name;
            phoneTextBox.Text = cus.Phone;
            emailTextBox.Text = cus.EMail;

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;

            KundKatalog.AddCustomer(name, phone, email);
        }

        private void UpdateInformationButton_Click(object sender, EventArgs e)
        {
            Customer cus = (Customer)customerListBox.SelectedItem;
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;

            try
            {
                KundKatalog.UpdateCustomer(cus.ID, name, phone, email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArchivedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
