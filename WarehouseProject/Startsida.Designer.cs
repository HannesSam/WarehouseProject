namespace WarehouseProject
{
    partial class Startsida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewOrder = new System.Windows.Forms.Button();
            this.CustomerManagement = new System.Windows.Forms.Button();
            this.ProductManagement = new System.Windows.Forms.Button();
            this.OrderManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewOrder
            // 
            this.NewOrder.Location = new System.Drawing.Point(120, 310);
            this.NewOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(125, 59);
            this.NewOrder.TabIndex = 0;
            this.NewOrder.Text = "Create New Order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // CustomerManagement
            // 
            this.CustomerManagement.Location = new System.Drawing.Point(644, 310);
            this.CustomerManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerManagement.Name = "CustomerManagement";
            this.CustomerManagement.Size = new System.Drawing.Size(125, 59);
            this.CustomerManagement.TabIndex = 0;
            this.CustomerManagement.Text = "Manage Customers";
            this.CustomerManagement.UseVisualStyleBackColor = true;
            this.CustomerManagement.Click += new System.EventHandler(this.CustomerManagement_Click);
            // 
            // ProductManagement
            // 
            this.ProductManagement.Location = new System.Drawing.Point(454, 310);
            this.ProductManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductManagement.Name = "ProductManagement";
            this.ProductManagement.Size = new System.Drawing.Size(125, 59);
            this.ProductManagement.TabIndex = 0;
            this.ProductManagement.Text = "Manage Products";
            this.ProductManagement.UseVisualStyleBackColor = true;
            this.ProductManagement.Click += new System.EventHandler(this.ProductManagement_Click);
            // 
            // OrderManagement
            // 
            this.OrderManagement.Location = new System.Drawing.Point(286, 310);
            this.OrderManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderManagement.Name = "OrderManagement";
            this.OrderManagement.Size = new System.Drawing.Size(125, 59);
            this.OrderManagement.TabIndex = 0;
            this.OrderManagement.Text = "Manage Orders";
            this.OrderManagement.UseVisualStyleBackColor = true;
            this.OrderManagement.Click += new System.EventHandler(this.OrderManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Warehouse";
            // 
            // Startsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 955);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderManagement);
            this.Controls.Add(this.ProductManagement);
            this.Controls.Add(this.CustomerManagement);
            this.Controls.Add(this.NewOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Startsida";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Startsida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button CustomerManagement;
        private System.Windows.Forms.Button ProductManagement;
        private System.Windows.Forms.Button OrderManagement;
        private System.Windows.Forms.Label label1;
    }
}

