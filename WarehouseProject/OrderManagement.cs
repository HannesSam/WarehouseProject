using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseProject
{
    /// <summary>
    /// I den här klassen kan användaren se olika order
    /// </summary>
    public partial class Order_management : Form
    {
        //kommentar
        public IProductCatalogue ProduktKatalog;
        public ICustomerCatalogue KundKatalog;
        public IOrderCatalogue OrderKatalog;

        public Order_management(IProductCatalogue _productCatalogue, ICustomerCatalogue _costumerCatalogue, IOrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;
            InitializeComponent();
            UpdateCustomerList();
            showall();

        }
        /// <summary>
        /// Visar alla ordrar i listboxoforders
        /// </summary>
        private void showall()
        {
            listBoxOfOrders.Items.Clear();
            label1.Text = "All orders";
            ProcessPendingOrdersButton.Visible = false;
            foreach (var item in OrderKatalog.Orders)
            {
                listBoxOfOrders.Items.Add(item);
            }
        }

        /// <summary>
        /// Uppdaterar customerListBox och tilldelar den alla kunder i kundkatalogen.
        /// </summary>
        private void UpdateCustomerList()
        {
            foreach (var item in KundKatalog.Customers)
            {
                customerListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Tar användaren tillbaka till startsidan.
        /// </summary>
        private void HomeButton_Click(object sender, EventArgs e)
        {
            var f = new Startsida(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Visar alla ordrar i orderkatalogen i listboxen listBoxOfOrders.
        /// </summary>
        private void ShowAllOrdersButton_Click(object sender, EventArgs e)
        {
            listBoxOfOrders.Items.Clear();
            label1.Text = "All orders";
            ProcessPendingOrdersButton.Visible = false;
            foreach (var item in OrderKatalog.Orders)
            {
                listBoxOfOrders.Items.Add(item);
            }
        }
        /// <summary>
        /// När användaren dubbelklickar på en order i listboxen så dyker en messagebox upp med ytterligare information.
        /// </summary>
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
                DateTime max = new DateTime();

                foreach (var item in order.Items)
                {
                    if (max < item.Product.FirstAvailable)
                    {
                        max = item.Product.FirstAvailable;
                    }
                }

                string firstavailable = max.ToString();

                string items = "";
                for (int i = 0; i < order.Items.Count; i++)
                {
                    items += "Product: " + order.Items[i].Product + " Quantity : " + order.Items[i].Count + "\n";
                }

                MessageBox.Show("Ordernumber : " + number + "\n" + "Customer : " + customer + "\nAdress: " + adress + "\n" + "Paid : " + payment + "\nRefunded : " + refunded + "\nDispatched : " + dispatched + "\n" + items + "\nFirstAvailable : " + firstavailable);
            }
        }

        /// <summary>
        /// Här kallas metoden DispatchReadyOrders som dispatchar alla orders som är redo. 
        /// </summary>
        private void ProcessPendingOrdersButton_Click(object sender, EventArgs e)
        {
            OrderKatalog.DispatchReadyOrders();
            showpendingorders();
            MessageBox.Show(" Pending orders processed");
        }

        /// <summary>
        /// Listboxen fylls med dispatchade orders.
        /// </summary>
        private void ShowDispatchedOrdersButton_Click(object sender, EventArgs e)
        {
            listBoxOfOrders.Items.Clear();
            ProcessPendingOrdersButton.Visible = false;
            label1.Text = "Dispatched orders";
            foreach (var item in OrderKatalog.GetDispatchedOrders())
            {
                listBoxOfOrders.Items.Add(item);
            }
        }

        /// <summary>
        /// Listboxen fylls med pending orders.
        /// </summary>
        private void ShowPendingOrdersButton_Click(object sender, EventArgs e)
        {
            showpendingorders();
        }
        /// <summary>
        /// Alla arkiverade ordrar från en vald kund visas i listboxOfOrders.
        /// </summary>
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

        /// <summary>
        /// Alla aktiva ordrar från en vald kund visas i listboxOfOrders.
        /// </summary>
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void showpendingorders()
        {
            listBoxOfOrders.Items.Clear();
            label1.Text = "Pending orders";
            ProcessPendingOrdersButton.Visible = true;
            foreach (var item in OrderKatalog.GetPendingOrders())
            {
                listBoxOfOrders.Items.Add(item);
            }
        }
    }
}

