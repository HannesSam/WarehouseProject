namespace WarehouseProject
{
    partial class Customer_management
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.ArchivedButton = new System.Windows.Forms.Button();
            this.ActiveOrdersButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateInformationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 15;
            this.customerListBox.Location = new System.Drawing.Point(37, 60);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(291, 184);
            this.customerListBox.TabIndex = 1;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(37, 250);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(92, 76);
            this.ShowAllButton.TabIndex = 2;
            this.ShowAllButton.Text = "Show All Customers";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // ArchivedButton
            // 
            this.ArchivedButton.Location = new System.Drawing.Point(138, 250);
            this.ArchivedButton.Name = "ArchivedButton";
            this.ArchivedButton.Size = new System.Drawing.Size(92, 76);
            this.ArchivedButton.TabIndex = 2;
            this.ArchivedButton.Text = "Show archived orders of selected customer";
            this.ArchivedButton.UseVisualStyleBackColor = true;
            // 
            // ActiveOrdersButton
            // 
            this.ActiveOrdersButton.Location = new System.Drawing.Point(236, 250);
            this.ActiveOrdersButton.Name = "ActiveOrdersButton";
            this.ActiveOrdersButton.Size = new System.Drawing.Size(92, 76);
            this.ActiveOrdersButton.TabIndex = 2;
            this.ActiveOrdersButton.Text = "Show Active Orders Of Selected Customer";
            this.ActiveOrdersButton.UseVisualStyleBackColor = true;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(567, 100);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(92, 48);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(373, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(373, 151);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 23);
            this.phoneTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(373, 206);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 23);
            this.emailTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMail";
            // 
            // UpdateInformationButton
            // 
            this.UpdateInformationButton.Location = new System.Drawing.Point(567, 206);
            this.UpdateInformationButton.Name = "UpdateInformationButton";
            this.UpdateInformationButton.Size = new System.Drawing.Size(92, 48);
            this.UpdateInformationButton.TabIndex = 2;
            this.UpdateInformationButton.Text = "Update Information";
            this.UpdateInformationButton.UseVisualStyleBackColor = true;
            this.UpdateInformationButton.Click += new System.EventHandler(this.UpdateInformationButton_Click);
            // 
            // Customer_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.UpdateInformationButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.ActiveOrdersButton);
            this.Controls.Add(this.ArchivedButton);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.HomeButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer_management";
            this.Text = "Customer_management";
            this.Load += new System.EventHandler(this.Customer_management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button ArchivedButton;
        private System.Windows.Forms.Button ActiveOrdersButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateInformationButton;
    }
}