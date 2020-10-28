namespace WarehouseProject
{
    partial class Product_management
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
            this.productListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.firstAvailableTextBox = new System.Windows.Forms.TextBox();
            this.nextStockingTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.ShowOutOfStockButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.ClosestRestockingButton = new System.Windows.Forms.Button();
            this.closestRestockingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 20;
            this.productListBox.Location = new System.Drawing.Point(30, 140);
            this.productListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(294, 304);
            this.productListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(22, 25);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(94, 29);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(389, 211);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(114, 27);
            this.priceTextBox.TabIndex = 4;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(389, 284);
            this.stockTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(114, 27);
            this.stockTextBox.TabIndex = 4;
            // 
            // firstAvailableTextBox
            // 
            this.firstAvailableTextBox.Location = new System.Drawing.Point(389, 358);
            this.firstAvailableTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstAvailableTextBox.Name = "firstAvailableTextBox";
            this.firstAvailableTextBox.Size = new System.Drawing.Size(143, 27);
            this.firstAvailableTextBox.TabIndex = 4;
            // 
            // nextStockingTextBox
            // 
            this.nextStockingTextBox.Location = new System.Drawing.Point(389, 432);
            this.nextStockingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextStockingTextBox.Name = "nextStockingTextBox";
            this.nextStockingTextBox.Size = new System.Drawing.Size(143, 27);
            this.nextStockingTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(389, 140);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(114, 27);
            this.nameTextBox.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(421, 116);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(49, 20);
            this.Name.TabIndex = 5;
            this.Name.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "FirstAvailable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "NextStocking";
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(30, 475);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(136, 83);
            this.ShowAllButton.TabIndex = 6;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // ShowOutOfStockButton
            // 
            this.ShowOutOfStockButton.Location = new System.Drawing.Point(192, 475);
            this.ShowOutOfStockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowOutOfStockButton.Name = "ShowOutOfStockButton";
            this.ShowOutOfStockButton.Size = new System.Drawing.Size(133, 83);
            this.ShowOutOfStockButton.TabIndex = 6;
            this.ShowOutOfStockButton.Text = "Show Out Of Stock";
            this.ShowOutOfStockButton.UseVisualStyleBackColor = true;
            this.ShowOutOfStockButton.Click += new System.EventHandler(this.ShowOutOfStockButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(551, 149);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(141, 83);
            this.AddProductButton.TabIndex = 6;
            this.AddProductButton.Text = "Add New Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Location = new System.Drawing.Point(551, 309);
            this.UpdateProductButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(141, 81);
            this.UpdateProductButton.TabIndex = 6;
            this.UpdateProductButton.Text = "Update Product Information";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // ClosestRestockingButton
            // 
            this.ClosestRestockingButton.Location = new System.Drawing.Point(619, 487);
            this.ClosestRestockingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClosestRestockingButton.Name = "ClosestRestockingButton";
            this.ClosestRestockingButton.Size = new System.Drawing.Size(133, 83);
            this.ClosestRestockingButton.TabIndex = 6;
            this.ClosestRestockingButton.Text = "Closest Restocking Date";
            this.ClosestRestockingButton.UseVisualStyleBackColor = true;
            this.ClosestRestockingButton.Click += new System.EventHandler(this.ClosestRestockingButton_Click);
            // 
            // closestRestockingTextBox
            // 
            this.closestRestockingTextBox.Location = new System.Drawing.Point(759, 515);
            this.closestRestockingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closestRestockingTextBox.Name = "closestRestockingTextBox";
            this.closestRestockingTextBox.Size = new System.Drawing.Size(126, 27);
            this.closestRestockingTextBox.TabIndex = 7;
            // 
            // Product_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.closestRestockingTextBox);
            this.Controls.Add(this.ClosestRestockingButton);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ShowOutOfStockButton);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nextStockingTextBox);
            this.Controls.Add(this.firstAvailableTextBox);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productListBox);
            this.Text = "Product_management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox firstAvailableTextBox;
        private System.Windows.Forms.TextBox nextStockingTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button ShowOutOfStockButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Button ClosestRestockingButton;
        private System.Windows.Forms.TextBox closestRestockingTextBox;
    }
}