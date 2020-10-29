using System;
using System.Windows.Forms;

namespace WarehouseProject
{
    /// <summary>
    /// Den här klassen tillåter användaren att se alla kunder, lägga till kunder och ändra kundinformation.
    /// </summary>
    public partial class Customer_management : Form
    {

        public IProductCatalogue ProduktKatalog;
        public ICustomerCatalogue KundKatalog;
        public IOrderCatalogue OrderKatalog;
        public Customer_management(IProductCatalogue _productCatalogue, ICustomerCatalogue _costumerCatalogue, IOrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;
            InitializeComponent();
            UpdateList();
            customerListBox.SelectedIndexChanged += CustomerListBoxChanged;

            KundKatalog.OnCustomerChange += UpdateList;
        }

        /// <summary>
        /// Metoden tillåter användaren att återgå till startsidan.
        /// </summary>
        private void HomeButton_Click(object sender, EventArgs e)
        {
            var f = new Startsida(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Uppdaterar customerListbox så att den innehåller alla kunder från kundkatalogen.
        /// </summary>
        private void UpdateList()
        {
            customerListBox.Items.Clear();
            foreach (var item in KundKatalog.Customers)
            {
                customerListBox.Items.Add(item);
            }
            customerListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Visar alla kunder från kundkatalogen i customerListBox.
        /// </summary>
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            customerListBox.Items.Clear();
            foreach (var item in KundKatalog.Customers)
            {
                customerListBox.Items.Add(item);
            }
            customerListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// När användaren väljer en annan kund i listboxen så tilldelas textboxarna kundens egenskaper.
        /// </summary>
        private void CustomerListBoxChanged(object sender, EventArgs e)
        {
            Customer cus = (Customer)customerListBox.SelectedItem;

            nameTextBox.Text = cus.Name;
            phoneTextBox.Text = cus.Phone;
            emailTextBox.Text = cus.EMail;

        }

        /// <summary>
        /// När denna knapp klickas på så används informationen som finns i textboxarna 
        /// till att göra en ny kund som läggs in i kundkatalogen. Om textboxarna innehåller
        /// en tom sträng så fångas ett stringemptyornullexception.
        /// </summary>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            try
            {
                KundKatalog.AddCustomer(name, phone, email);
            }
            catch (StringEmptyOrNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Egenskaperna hos den valda kunden uppdateras till det som användaren har 
        /// skrivit in i textboxarna. Om ingen kund är vald så uppdateras inte informationen. 
        /// Om det är fel format på informationen så fångas ett StringEmptyOrNullException.
        /// </summary>
        private void UpdateInformationButton_Click(object sender, EventArgs e)
        {
            Customer cus = (Customer)customerListBox.SelectedItem;
            if (cus == null)
            {
                MessageBox.Show("Please select a customer to update");
            }
            else
            {
                string name = nameTextBox.Text;
                string phone = phoneTextBox.Text;
                string email = emailTextBox.Text;

                try
                {
                    KundKatalog.UpdateCustomer(cus.ID, name, phone, email);
                }
                catch (StringEmptyOrNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
