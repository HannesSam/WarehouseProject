using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass tillåter användaren att se alla produkter, lägga till nya produkter och ändra information i produkter. 
    /// </summary>
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

        /// <summary>
        /// Denna knapp tar användaren tillbaka till startsidan.
        /// </summary>
        private void HomeButton_Click(object sender, EventArgs e)
        {
            var f = new Startsida(ProduktKatalog, KundKatalog, OrderKatalog);
            Hide();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Visar alla produkter i ProduktKatalogen i productListBox.
        /// </summary>
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            foreach (var item in ProduktKatalog.AllProducts())
            {
                productListBox.Items.Add(item);
            }
        }
        /// <summary>
        /// Alla egenskaper hos den valda produkten visas för användaren i textboxarna.
        /// </summary>
        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product pro = (Product)productListBox.SelectedItem;
            if (pro == null)
            {
                MessageBox.Show("Please choose a product");
            }
            else
            {
                nameTextBox.Text = pro.Name;
                priceTextBox.Text = pro.Price.ToString();
                stockTextBox.Text = pro.Stock.ToString();
                firstAvailableTextBox.Text = pro.FirstAvailable.ToString();
                nextStockingTextBox.Text = pro.NextStocking.ToString();
            }
        }
        /// <summary>
        /// UpdateList refreshar alla produkter från produktkatalogen i listboxen.
        /// </summary>
        private void UpdateList()
        {
            productListBox.Items.Clear();
            foreach (var item in ProduktKatalog.AllProducts())
            {
                productListBox.Items.Add(item);
            }
        }
        /// <summary>
        /// Alla produkter där Stock = 0 visas i productlistbox.
        /// </summary>
        private void ShowOutOfStockButton_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            foreach (var item in ProduktKatalog.ProductsOutOfStock())
            {
                productListBox.Items.Add(item);
            }
        }
        /// <summary>
        /// Lägger till en ny produkt i produktkatalogen utifrån informationen i TextBoxarna. 
        /// Om textboxarna är tomma eller null eller om användaren har angett en sträng till 
        /// en textbox som ska innehålla en int så fångas felet med exceptions.
        /// </summary>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            try
            {
                double price = double.Parse(priceTextBox.Text);
                try
                {
                    int stock = int.Parse(stockTextBox.Text);
                    try
                    {
                        DateTime firstAvailable = DateTime.Parse(firstAvailableTextBox.Text);
                        try
                        {
                            DateTime nextStock = DateTime.Parse(nextStockingTextBox.Text);
                            try
                            {
                                ProduktKatalog.AddProduct(name, price, stock, firstAvailable, nextStock);
                            }
                            catch (IntOrDoubleNegativeException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            catch (DateNotInFutureException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            catch (StringEmptyOrNullException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Next stock date must be in a date format (ex: June 4, 2021)");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("First available date must be in a date format (ex: June 4, 2021)");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Stock must be a number");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Price must be a number");
            }


            UpdateList();
        }
        /// <summary>
        /// Uppdaterar den produkten från katalogen som är vald i listboxen utifrån informationen i textboxarna.
        /// Om textboxarna är tomma eller null eller om användaren har angett en sträng till 
        /// en textbox som ska innehålla en int så fångas felet med exceptions.
        /// </summary>
        private void UpdateProductButton_Click(object sender, EventArgs e)
        {

            Product pro = (Product)productListBox.SelectedItem;
            if (pro == null)
            {
                MessageBox.Show("Please select a product to be updated.");
            }
            else
            {
                int code = pro.Code;
                string name = nameTextBox.Text;
                try
                {
                    double price = double.Parse(priceTextBox.Text);
                    try
                    {
                        int stock = int.Parse(stockTextBox.Text);
                        try
                        {
                            DateTime firstAvailable = DateTime.Parse(firstAvailableTextBox.Text);
                            try
                            {
                                DateTime nextStock = DateTime.Parse(nextStockingTextBox.Text);
                                try
                                {
                                    ProduktKatalog.UpdateInformation(code, name, price, stock, firstAvailable, nextStock);
                                }
                                catch (IntOrDoubleNegativeException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                catch (DateNotInFutureException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                catch (StringEmptyOrNullException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Next stock date must be in a date format (ex: June 4, 2021)");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("First available date must be in a date format (ex: June 4, 2021)");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Stock must be a number");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Price must be a number");
                }
            }
            UpdateList();
        }


        /// <summary>
        /// Anger den närmsta stocking datumet till closestRestockingTextBox.
        /// </summary>
        private void ClosestRestockingButton_Click(object sender, EventArgs e)
        {
            closestRestockingTextBox.Text = ProduktKatalog.NextRestocking().ToString();
        }
    }
}
