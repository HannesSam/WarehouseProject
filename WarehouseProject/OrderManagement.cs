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

        private void ShowDispatchedOrdersButton_Click(object sender, EventArgs e)
        {
            listBoxOfOrders.Items.Clear();
            foreach (var item in OrderKatalog.GetDispatchedOrders())
            {
                listBoxOfOrders.Items.Add(item);
            }
        }

        private void ShowPendingOrdersButton_Click(object sender, EventArgs e)
        {
            listBoxOfOrders.Items.Clear();
            foreach (var item in OrderKatalog.GetPendingOrders())
            {
                listBoxOfOrders.Items.Add(item);
            }
        }

        private void ProcessPendingOrdersButton_Click(object sender, EventArgs e)
        {
            OrderKatalog.DispatchReadyOrders();
        }

    }
}

