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
            this.textBoxdelivery = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.ListBox();
            this.textBoxQuantity = new System.Windows.Forms.NumericUpDown();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxProducts
            // 
            this.checkedListBoxProducts.FormattingEnabled = true;
            this.checkedListBoxProducts.Location = new System.Drawing.Point(31, 134);
            this.checkedListBoxProducts.Name = "checkedListBoxProducts";
            this.checkedListBoxProducts.Size = new System.Drawing.Size(238, 166);
            this.checkedListBoxProducts.TabIndex = 1;            // 
            // checkedListBoxOrderLine
            // 
            this.checkedListBoxOrderLine.FormattingEnabled = true;
            this.checkedListBoxOrderLine.Location = new System.Drawing.Point(371, 134);
            this.checkedListBoxOrderLine.Name = "checkedListBoxOrderLine";
            this.checkedListBoxOrderLine.Size = new System.Drawing.Size(220, 166);
            this.checkedListBoxOrderLine.TabIndex = 2;
            // 
            // textBoxdelivery
            // 
            this.textBoxdelivery.Location = new System.Drawing.Point(371, 93);
            this.textBoxdelivery.Name = "textBoxdelivery";
            this.textBoxdelivery.Size = new System.Drawing.Size(220, 23);
            this.textBoxdelivery.TabIndex = 3;            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(275, 212);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(90, 23);
            this.AddProductButton.TabIndex = 4;
            this.AddProductButton.Text = "Add product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(632, 245);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(126, 55);
            this.CreateOrderButton.TabIndex = 5;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // Customer
            // 
            this.Customer.FormattingEnabled = true;
            this.Customer.ItemHeight = 15;
            this.Customer.Location = new System.Drawing.Point(371, 23);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(220, 64);
            this.Customer.TabIndex = 6;            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(275, 183);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(90, 23);
            this.textBoxQuantity.TabIndex = 7;
            this.textBoxQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});            // 
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
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(275, 245);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(90, 23);
            this.ButtonRemove.TabIndex = 9;
            this.ButtonRemove.Text = "Remove product";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Delivery Adress";            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose customer";
            // 
            // Create_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.textBoxdelivery);
            this.Controls.Add(this.checkedListBoxOrderLine);
            this.Controls.Add(this.checkedListBoxProducts);
            this.Name = "Create_order";
            this.Text = "Create_order";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxProducts;
        private System.Windows.Forms.CheckedListBox checkedListBoxOrderLine;
        private System.Windows.Forms.TextBox textBoxdelivery;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.ListBox Customer;
        private System.Windows.Forms.NumericUpDown textBoxQuantity;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}