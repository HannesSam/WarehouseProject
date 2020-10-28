using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseProject
{
    public partial class Order_management : Form
    {
        //kommentar
        public ProductCatalogue ProduktKatalog;
        public CustomerCatalogue KundKatalog;
        public OrderCatalogue OrderKatalog;
        public Order_management(ProductCatalogue _productCatalogue, CustomerCatalogue _costumerCatalogue, OrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;
            InitializeComponent();
            UpdateCustomerList();
        }

        private void UpdateCustomerList()
        {
            foreach (var item in KundKatalog.Customers)
            {
                customerListBox.Items.Add(item);
            }
        }
        private void Order_management_Load(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var f = new Startsida(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        private void ShowAllOrdersButton_Click(object sender, EventArgs e)
        {
            listBoxOfOrders.Items.Clear();
            foreach (var item in OrderKatalog.Orders)
            {
                listBoxOfOrders.Items.Add(item);
            }
        }
        private void listBoxOfOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBoxOfOrders_DoubleClick(object sender, EventArgs e)
        {

            Order order = (Order)listBoxOfOrders.SelectedItem;
            if (order == null)
            {
                MessageBox.Show("Please select an order");
            }
            else
            {
                string payment = order.PaymentCompleted ? "Yes" : "No";
                string refunded = order.PaymentRefunded ? "Yes" : "No";
                string dispatched = order.Dispatched ? "Yes" : "No";
                string adress = order.DeliveryAdress;
                string number = order.Number.ToString();
                string customer = order.Customer.Name;

                string items = "";
                for (int i = 0; i < order.Items.Count; i++)
                {
                    items += "Product: " + order.Items[i].Product + " Quantity : " + order.Items[i].Count + "\n";
                }

                MessageBox.Show("Ordernumber : " + number + "\n" + "Customer : " + customer + "\nAdress: " + adress + "\n" + "Paid : " + payment + "\nRefunded : " + refunded + "\nDispatched : " + dispatched + "\n" + items);
            }
        }

        private void ShowArchivedButton_Click(object sender, EventArgs e)
        {
            Customer kund = (Customer)customerListBox.SelectedItem;
            List<Order> archivedOrders = OrderKatalog.GetDispatchedOrdersFrom(kund);
            listBoxOfOrders.Items.Clear();
            foreach (var item in archivedOrders)
            {
                listBoxOfOrders.Items.Add(item);
            }
        }

        private void ShowActiveButton_Click(object sender, EventArgs e)
        {
            Customer kund = (Customer)customerListBox.SelectedItem;
            if (kund == null)
            {
                MessageBox.Show("Please select a customer.");
            }
            else if (!OrderKatalog.HasOrder(kund))
            {
                MessageBox.Show("This customer has never placed any orders.");
            }
            else
            {
                List<Order> activeOrders = OrderKatalog.GetActiveOrdersFrom(kund);
                listBoxOfOrders.Items.Clear();
                foreach (var item in activeOrders)
                {
                    listBoxOfOrders.Items.Add(item);
                }
            }
        }
    }
}

