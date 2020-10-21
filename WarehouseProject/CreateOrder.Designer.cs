namespace WarehouseProject
{
    partial class Create_order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxProducts = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxOrderLine = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.ListBox();
            this.textBoxQuantity = new System.Windows.Forms.NumericUpDown();
            this.HomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxProducts
            // 
            this.checkedListBoxProducts.FormattingEnabled = true;
            this.checkedListBoxProducts.Location = new System.Drawing.Point(31, 134);
            this.checkedListBoxProducts.Name = "checkedListBoxProducts";
            this.checkedListBoxProducts.Size = new System.Drawing.Size(238, 166);
            this.checkedListBoxProducts.TabIndex = 1;
            // 
            // checkedListBoxOrderLine
            // 
            this.checkedListBoxOrderLine.FormattingEnabled = true;
            this.checkedListBoxOrderLine.Location = new System.Drawing.Point(371, 134);
            this.checkedListBoxOrderLine.Name = "checkedListBoxOrderLine";
            this.checkedListBoxOrderLine.Size = new System.Drawing.Size(220, 166);
            this.checkedListBoxOrderLine.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = " Delivery adress";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(275, 212);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(90, 23);
            this.AddProductButton.TabIndex = 4;
            this.AddProductButton.Text = "Add product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(634, 263);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(126, 55);
            this.CreateOrderButton.TabIndex = 5;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.Customer.FormattingEnabled = true;
            this.Customer.ItemHeight = 15;
            this.Customer.Location = new System.Drawing.Point(371, 38);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(100, 34);
            this.Customer.TabIndex = 6;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(275, 183);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(90, 23);
            this.textBoxQuantity.TabIndex = 7;
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // Create_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBoxOrderLine);
            this.Controls.Add(this.checkedListBoxProducts);
            this.Name = "Create_order";
            this.Text = "Create_order";
            this.Load += new System.EventHandler(this.Create_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxProducts;
        private System.Windows.Forms.CheckedListBox checkedListBoxOrderLine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.ListBox Customer;
        private System.Windows.Forms.NumericUpDown textBoxQuantity;
        private System.Windows.Forms.Button HomeButton;
    }
}