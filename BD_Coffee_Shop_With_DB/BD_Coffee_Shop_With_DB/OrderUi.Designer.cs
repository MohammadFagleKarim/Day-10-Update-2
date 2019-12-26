namespace BD_Coffee_Shop_With_DB
{
    partial class OrderUi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.orderCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderItemComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.orderTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderSaveBtn = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // orderCustomerComboBox
            // 
            this.orderCustomerComboBox.DataSource = this.customersBindingSource;
            this.orderCustomerComboBox.DisplayMember = "CustomerName";
            this.orderCustomerComboBox.FormattingEnabled = true;
            this.orderCustomerComboBox.Location = new System.Drawing.Point(197, 28);
            this.orderCustomerComboBox.Name = "orderCustomerComboBox";
            this.orderCustomerComboBox.Size = new System.Drawing.Size(193, 21);
            this.orderCustomerComboBox.TabIndex = 1;
            this.orderCustomerComboBox.ValueMember = "CustomerId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item";
            // 
            // orderItemComboBox
            // 
            this.orderItemComboBox.DataSource = this.itemsBindingSource;
            this.orderItemComboBox.DisplayMember = "ItemName";
            this.orderItemComboBox.FormattingEnabled = true;
            this.orderItemComboBox.Location = new System.Drawing.Point(197, 69);
            this.orderItemComboBox.Name = "orderItemComboBox";
            this.orderItemComboBox.Size = new System.Drawing.Size(193, 21);
            this.orderItemComboBox.TabIndex = 1;
            this.orderItemComboBox.ValueMember = "ItemId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Price";
            // 
            // orderQuantityTextBox
            // 
            this.orderQuantityTextBox.Location = new System.Drawing.Point(197, 108);
            this.orderQuantityTextBox.Name = "orderQuantityTextBox";
            this.orderQuantityTextBox.Size = new System.Drawing.Size(193, 20);
            this.orderQuantityTextBox.TabIndex = 2;
            // 
            // orderTotalPriceTextBox
            // 
            this.orderTotalPriceTextBox.Location = new System.Drawing.Point(197, 149);
            this.orderTotalPriceTextBox.Name = "orderTotalPriceTextBox";
            this.orderTotalPriceTextBox.Size = new System.Drawing.Size(193, 20);
            this.orderTotalPriceTextBox.TabIndex = 2;
            // 
            // orderSaveBtn
            // 
            this.orderSaveBtn.Location = new System.Drawing.Point(296, 190);
            this.orderSaveBtn.Name = "orderSaveBtn";
            this.orderSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.orderSaveBtn.TabIndex = 3;
            this.orderSaveBtn.Text = "SAVE";
            this.orderSaveBtn.UseVisualStyleBackColor = true;
            this.orderSaveBtn.Click += new System.EventHandler(this.orderSaveBtn_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(58, 230);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(812, 224);
            this.orderDataGridView.TabIndex = 4;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(BD_Coffee_Shop_With_DB.Model.Customers);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(BD_Coffee_Shop_With_DB.Model.Items);
            // 
            // OrderUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 477);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.orderSaveBtn);
            this.Controls.Add(this.orderTotalPriceTextBox);
            this.Controls.Add(this.orderQuantityTextBox);
            this.Controls.Add(this.orderItemComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderCustomerComboBox);
            this.Controls.Add(this.label1);
            this.Name = "OrderUi";
            this.Text = "Order Information";
            this.Load += new System.EventHandler(this.OrderUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox orderCustomerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orderItemComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderQuantityTextBox;
        private System.Windows.Forms.TextBox orderTotalPriceTextBox;
        private System.Windows.Forms.Button orderSaveBtn;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
    }
}