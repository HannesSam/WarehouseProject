using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseProject

/// <summary>
/// I denna klass kan användaren skapa nya ordrar
/// </summary>
{
    public partial class Create_order : Form
    {

        public IProductCatalogue ProduktKatalog;
        public ICustomerCatalogue KundKatalog;
        public IOrderCatalogue OrderKatalog;
        public List<OrderLine> ProduktLista;
        public Create_order(IProductCatalogue _productCatalogue, ICustomerCatalogue _costumerCatalogue, IOrderCatalogue _orderCatalogue)
        {
            this.ProduktKatalog = _productCatalogue;
            this.KundKatalog = _costumerCatalogue;
            this.OrderKatalog = _orderCatalogue;

            ProduktLista = new List<OrderLine>();
            InitializeComponent();
            UpdateList();

        }

        /// <summary>
        /// Updaterar våra listboxes med senaste produktlistan samt senaste kundlistan
        /// </summary>
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
            checkedListBoxProducts.DisplayMember = "Name" + " " + "Stock";
        }
        /// <summary>
        /// Tickar i alla boxes i checkedListBoxOrderLine
        /// </summary>
        private void checkedlist()
        {
            for (int i = 0; i < checkedListBoxOrderLine.Items.Count; i++)
            {
                checkedListBoxOrderLine.SetItemChecked(i, true);
            }
        }
        /// <summary>
        /// Homeknapp, tar en tillbaka till startsida
        /// </summary>
        private void HomeButton_Click(object sender, EventArgs e)
        {
            var f = new Startsida(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }
        /// <summary>
        /// Lägger till produkter till en ny orderlista
        /// </summary>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            decimal decimalcount = textBoxQuantity.Value;
            if (decimalcount <= 0)
            {
                MessageBox.Show("Please select a quantity higher than 0");
            }

            else
            {
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
            checkedlist();
        }
        /// <summary>
        /// Uppdaterar listbox 
        /// </summary>
        private void UpdateSelectedList()
        {
            List<OrderLine> update = checkedListBoxOrderLine.Items.OfType<OrderLine>().ToList();

            checkedListBoxOrderLine.Items.Clear();
            foreach (var item in update)
            {
                checkedListBoxOrderLine.Items.Add(item);
            }

        }
        /// <summary>
        /// KOllar om en produkt finns i en lista
        /// </summary>
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

        /// <summary>
        /// Tar bort dom icheckade objekten från checkedlistboxorderline
        /// </summary>
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
        /// <summary>
        /// Skapar ny order
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Customer customerreference = (Customer)Customer.SelectedItem;
            if (customerreference == null)
            {
                MessageBox.Show("Please select a customer.");
            }
            else if (checkedListBoxOrderLine.Items.Count == 0)
            {
                MessageBox.Show("No products selected.");
            }
            else
            {
                string adress = textBoxdelivery.Text;

                List<OrderLine> produktlista = new List<OrderLine>();

                foreach (OrderLine item in checkedListBoxOrderLine.Items)
                {
                    produktlista.Add(item);
                }
                try
                {
                    OrderKatalog.AddOrder(customerreference, adress, produktlista);
                    MessageBox.Show("Order placed successfully!");
                }
                catch (ProductNotInCatalogueException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (StringEmptyOrNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
