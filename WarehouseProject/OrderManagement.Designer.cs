namespace WarehouseProject
{
    partial class Order_management
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
            this.ShowAllOrdersButton = new System.Windows.Forms.Button();
            this.ShowDispatchedOrdersButton = new System.Windows.Forms.Button();
            this.ShowPendingOrdersButton = new System.Windows.Forms.Button();
            this.listBoxOfOrders = new System.Windows.Forms.ListBox();
            this.ProcessPendingOrdersButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowAllOrdersButton
            // 
            this.ShowAllOrdersButton.Location = new System.Drawing.Point(160, 378);
            this.ShowAllOrdersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowAllOrdersButton.Name = "ShowAllOrdersButton";
            this.ShowAllOrdersButton.Size = new System.Drawing.Size(162, 31);
            this.ShowAllOrdersButton.TabIndex = 0;
            this.ShowAllOrdersButton.Text = "Show all orders";
            this.ShowAllOrdersButton.UseVisualStyleBackColor = true;
            this.ShowAllOrdersButton.Click += new System.EventHandler(this.ShowAllOrdersButton_Click);
            // 
            // ShowDispatchedOrdersButton
            // 
            this.ShowDispatchedOrdersButton.Location = new System.Drawing.Point(160, 417);
            this.ShowDispatchedOrdersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowDispatchedOrdersButton.Name = "ShowDispatchedOrdersButton";
            this.ShowDispatchedOrdersButton.Size = new System.Drawing.Size(162, 31);
            this.ShowDispatchedOrdersButton.TabIndex = 0;
            this.ShowDispatchedOrdersButton.Text = "Show dispatched orders";
            this.ShowDispatchedOrdersButton.UseVisualStyleBackColor = true;
            this.ShowDispatchedOrdersButton.Click += new System.EventHandler(this.ShowDispatchedOrdersButton_Click);
            // 
            // ShowPendingOrdersButton
            // 
            this.ShowPendingOrdersButton.Location = new System.Drawing.Point(160, 456);
            this.ShowPendingOrdersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPendingOrdersButton.Name = "ShowPendingOrdersButton";
            this.ShowPendingOrdersButton.Size = new System.Drawing.Size(162, 31);
            this.ShowPendingOrdersButton.TabIndex = 0;
            this.ShowPendingOrdersButton.Text = "Show pending orders";
            this.ShowPendingOrdersButton.UseVisualStyleBackColor = true;
            this.ShowPendingOrdersButton.Click += new System.EventHandler(this.ShowPendingOrdersButton_Click);
            // 
            // listBoxOfOrders
            // 
            this.listBoxOfOrders.FormattingEnabled = true;
            this.listBoxOfOrders.ItemHeight = 20;
            this.listBoxOfOrders.Location = new System.Drawing.Point(105, 145);
            this.listBoxOfOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxOfOrders.Name = "listBoxOfOrders";
            this.listBoxOfOrders.Size = new System.Drawing.Size(285, 184);
            this.listBoxOfOrders.TabIndex = 1;
            this.listBoxOfOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOfOrders_SelectedIndexChanged);
            this.listBoxOfOrders.DoubleClick += new System.EventHandler(this.listBoxOfOrders_DoubleClick);
            // 
            // ProcessPendingOrdersButton
            // 
            this.ProcessPendingOrdersButton.Location = new System.Drawing.Point(160, 339);
            this.ProcessPendingOrdersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProcessPendingOrdersButton.Name = "ProcessPendingOrdersButton";
            this.ProcessPendingOrdersButton.Size = new System.Drawing.Size(162, 31);
            this.ProcessPendingOrdersButton.TabIndex = 0;
            this.ProcessPendingOrdersButton.Text = "Process pending orders";
            this.ProcessPendingOrdersButton.UseVisualStyleBackColor = true;
            this.ProcessPendingOrdersButton.Click += new System.EventHandler(this.ProcessPendingOrdersButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(14, 16);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(165, 31);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 20;
            this.customerListBox.Location = new System.Drawing.Point(664, 133);
            this.customerListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(217, 184);
            this.customerListBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 119);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Active Orders Of Selected Customer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 119);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show archived orders of selected customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Order_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.ProcessPendingOrdersButton);
            this.Controls.Add(this.listBoxOfOrders);
            this.Controls.Add(this.ShowPendingOrdersButton);
            this.Controls.Add(this.ShowDispatchedOrdersButton);
            this.Controls.Add(this.ShowAllOrdersButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Order_management";
            this.Text = "Order_management";
            this.Load += new System.EventHandler(this.Order_management_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShowAllOrdersButton;
        private System.Windows.Forms.Button ShowDispatchedOrdersButton;
        private System.Windows.Forms.Button ShowPendingOrdersButton;
        private System.Windows.Forms.ListBox listBoxOfOrders;
        private System.Windows.Forms.Button ProcessPendingOrdersButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}