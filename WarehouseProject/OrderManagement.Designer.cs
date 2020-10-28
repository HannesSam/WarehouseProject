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
            this.ShowActiveButton = new System.Windows.Forms.Button();
            this.ShowArchivedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowAllOrdersButton
            // 
            this.ShowAllOrdersButton.Location = new System.Drawing.Point(140, 284);
            this.ShowAllOrdersButton.Name = "ShowAllOrdersButton";
            this.ShowAllOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.ShowAllOrdersButton.TabIndex = 0;
            this.ShowAllOrdersButton.Text = "Show all orders";
            this.ShowAllOrdersButton.UseVisualStyleBackColor = true;
            this.ShowAllOrdersButton.Click += new System.EventHandler(this.ShowAllOrdersButton_Click);
            // 
            // ShowDispatchedOrdersButton
            // 
            this.ShowDispatchedOrdersButton.Location = new System.Drawing.Point(140, 313);
            this.ShowDispatchedOrdersButton.Name = "ShowDispatchedOrdersButton";
            this.ShowDispatchedOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.ShowDispatchedOrdersButton.TabIndex = 0;
            this.ShowDispatchedOrdersButton.Text = "Show dispatched orders";
            this.ShowDispatchedOrdersButton.UseVisualStyleBackColor = true;
            this.ShowDispatchedOrdersButton.Click += new System.EventHandler(this.ShowDispatchedOrdersButton_Click);
            // 
            // ShowPendingOrdersButton
            // 
            this.ShowPendingOrdersButton.Location = new System.Drawing.Point(140, 342);
            this.ShowPendingOrdersButton.Name = "ShowPendingOrdersButton";
            this.ShowPendingOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.ShowPendingOrdersButton.TabIndex = 0;
            this.ShowPendingOrdersButton.Text = "Show pending orders";
            this.ShowPendingOrdersButton.UseVisualStyleBackColor = true;
            this.ShowPendingOrdersButton.Click += new System.EventHandler(this.ShowPendingOrdersButton_Click);
            // 
            // listBoxOfOrders
            // 
            this.listBoxOfOrders.FormattingEnabled = true;
            this.listBoxOfOrders.ItemHeight = 15;
            this.listBoxOfOrders.Location = new System.Drawing.Point(92, 109);
            this.listBoxOfOrders.Name = "listBoxOfOrders";
            this.listBoxOfOrders.Size = new System.Drawing.Size(250, 139);
            this.listBoxOfOrders.TabIndex = 1;
            this.listBoxOfOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOfOrders_SelectedIndexChanged);
            this.listBoxOfOrders.DoubleClick += new System.EventHandler(this.listBoxOfOrders_DoubleClick);
            // 
            // ProcessPendingOrdersButton
            // 
            this.ProcessPendingOrdersButton.Location = new System.Drawing.Point(358, 168);
            this.ProcessPendingOrdersButton.Name = "ProcessPendingOrdersButton";
            this.ProcessPendingOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.ProcessPendingOrdersButton.TabIndex = 0;
            this.ProcessPendingOrdersButton.Text = "Process pending orders";
            this.ProcessPendingOrdersButton.UseVisualStyleBackColor = true;
            this.ProcessPendingOrdersButton.Click += new System.EventHandler(this.ProcessPendingOrdersButton_Click);
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
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 15;
            this.customerListBox.Location = new System.Drawing.Point(581, 100);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(190, 139);
            this.customerListBox.TabIndex = 1;
            // 
            // ShowActiveButton
            // 
            this.ShowActiveButton.Location = new System.Drawing.Point(679, 260);
            this.ShowActiveButton.Name = "ShowActiveButton";
            this.ShowActiveButton.Size = new System.Drawing.Size(92, 89);
            this.ShowActiveButton.TabIndex = 2;
            this.ShowActiveButton.Text = "Show Active Orders Of Selected Customer";
            this.ShowActiveButton.UseVisualStyleBackColor = true;
            this.ShowActiveButton.Click += new System.EventHandler(this.ShowActiveButton_Click);
            // 
            // ShowArchivedButton
            // 
            this.ShowArchivedButton.Location = new System.Drawing.Point(581, 260);
            this.ShowArchivedButton.Name = "ShowArchivedButton";
            this.ShowArchivedButton.Size = new System.Drawing.Size(92, 89);
            this.ShowArchivedButton.TabIndex = 2;
            this.ShowArchivedButton.Text = "Show archived orders of selected customer";
            this.ShowArchivedButton.UseVisualStyleBackColor = true;
            this.ShowArchivedButton.Click += new System.EventHandler(this.ShowArchivedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dispatched?";
            // 
            // Order_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowArchivedButton);
            this.Controls.Add(this.ShowActiveButton);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.ProcessPendingOrdersButton);
            this.Controls.Add(this.listBoxOfOrders);
            this.Controls.Add(this.ShowPendingOrdersButton);
            this.Controls.Add(this.ShowDispatchedOrdersButton);
            this.Controls.Add(this.ShowAllOrdersButton);
            this.Name = "Order_management";
            this.Text = "Order_management";
            this.Load += new System.EventHandler(this.Order_management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowAllOrdersButton;
        private System.Windows.Forms.Button ShowDispatchedOrdersButton;
        private System.Windows.Forms.Button ShowPendingOrdersButton;
        private System.Windows.Forms.ListBox listBoxOfOrders;
        private System.Windows.Forms.Button ProcessPendingOrdersButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.Button ShowActiveButton;
        private System.Windows.Forms.Button ShowArchivedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}