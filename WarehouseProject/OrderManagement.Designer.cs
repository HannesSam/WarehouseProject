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
            this.CreateNewOrderButton = new System.Windows.Forms.Button();
            this.ShowAllOrdersButton = new System.Windows.Forms.Button();
            this.ShowDispatchedOrdersButton = new System.Windows.Forms.Button();
            this.ShowPendingOrdersButton = new System.Windows.Forms.Button();
            this.listBoxOfOrders = new System.Windows.Forms.ListBox();
            this.ProcessPendingOrdersButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewOrderButton
            // 
            this.CreateNewOrderButton.Location = new System.Drawing.Point(12, 100);
            this.CreateNewOrderButton.Name = "CreateNewOrderButton";
            this.CreateNewOrderButton.Size = new System.Drawing.Size(142, 23);
            this.CreateNewOrderButton.TabIndex = 0;
            this.CreateNewOrderButton.Text = "Create new order";
            this.CreateNewOrderButton.UseVisualStyleBackColor = true;
            // 
            // ShowAllOrdersButton
            // 
            this.ShowAllOrdersButton.Location = new System.Drawing.Point(12, 145);
            this.ShowAllOrdersButton.Name = "ShowAllOrdersButton";
            this.ShowAllOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.ShowAllOrdersButton.TabIndex = 0;
            this.ShowAllOrdersButton.Text = "Show all orders";
            this.ShowAllOrdersButton.UseVisualStyleBackColor = true;
            // 
            // ShowDispatchedOrdersButton
            // 
            this.ShowDispatchedOrdersButton.Location = new System.Drawing.Point(12, 174);
            this.ShowDispatchedOrdersButton.Name = "ShowDispatchedOrdersButton";
            this.ShowDispatchedOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.ShowDispatchedOrdersButton.TabIndex = 0;
            this.ShowDispatchedOrdersButton.Text = "Show dispatched orders";
            this.ShowDispatchedOrdersButton.UseVisualStyleBackColor = true;
            // 
            // ShowPendingOrdersButton
            // 
            this.ShowPendingOrdersButton.Location = new System.Drawing.Point(12, 203);
            this.ShowPendingOrdersButton.Name = "ShowPendingOrdersButton";
            this.ShowPendingOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.ShowPendingOrdersButton.TabIndex = 0;
            this.ShowPendingOrdersButton.Text = "Show pending orders";
            this.ShowPendingOrdersButton.UseVisualStyleBackColor = true;
            // 
            // listBoxOfOrders
            // 
            this.listBoxOfOrders.FormattingEnabled = true;
            this.listBoxOfOrders.ItemHeight = 15;
            this.listBoxOfOrders.Location = new System.Drawing.Point(160, 100);
            this.listBoxOfOrders.Name = "listBoxOfOrders";
            this.listBoxOfOrders.Size = new System.Drawing.Size(250, 199);
            this.listBoxOfOrders.TabIndex = 1;
            this.listBoxOfOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOfOrders_SelectedIndexChanged);
            // 
            // ProcessPendingOrdersButton
            // 
            this.ProcessPendingOrdersButton.Location = new System.Drawing.Point(208, 305);
            this.ProcessPendingOrdersButton.Name = "ProcessPendingOrdersButton";
            this.ProcessPendingOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.ProcessPendingOrdersButton.TabIndex = 0;
            this.ProcessPendingOrdersButton.Text = "Process pending orders";
            this.ProcessPendingOrdersButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(144, 23);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // Order_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.ProcessPendingOrdersButton);
            this.Controls.Add(this.listBoxOfOrders);
            this.Controls.Add(this.ShowPendingOrdersButton);
            this.Controls.Add(this.ShowDispatchedOrdersButton);
            this.Controls.Add(this.ShowAllOrdersButton);
            this.Controls.Add(this.CreateNewOrderButton);
            this.Name = "Order_management";
            this.Text = "Order_management";
            this.Load += new System.EventHandler(this.Order_management_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewOrderButton;
        private System.Windows.Forms.Button ShowAllOrdersButton;
        private System.Windows.Forms.Button ShowDispatchedOrdersButton;
        private System.Windows.Forms.Button ShowPendingOrdersButton;
        private System.Windows.Forms.ListBox listBoxOfOrders;
        private System.Windows.Forms.Button ProcessPendingOrdersButton;
        private System.Windows.Forms.Button HomeButton;
    }
}