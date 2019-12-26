namespace BD_Coffee_Shop_With_DB
{
    partial class ItemUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemAddBtn = new System.Windows.Forms.Button();
            this.itemDeleteBtn = new System.Windows.Forms.Button();
            this.itemUpdateBtn = new System.Windows.Forms.Button();
            this.itemSearchBtn = new System.Windows.Forms.Button();
            this.itemShowBtn = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(156, 56);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(249, 20);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(156, 97);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(249, 20);
            this.itemPriceTextBox.TabIndex = 1;
            // 
            // itemAddBtn
            // 
            this.itemAddBtn.Location = new System.Drawing.Point(156, 156);
            this.itemAddBtn.Name = "itemAddBtn";
            this.itemAddBtn.Size = new System.Drawing.Size(75, 23);
            this.itemAddBtn.TabIndex = 2;
            this.itemAddBtn.Text = "ADD";
            this.itemAddBtn.UseVisualStyleBackColor = true;
            this.itemAddBtn.Click += new System.EventHandler(this.itemAddBtn_Click);
            // 
            // itemDeleteBtn
            // 
            this.itemDeleteBtn.Location = new System.Drawing.Point(261, 156);
            this.itemDeleteBtn.Name = "itemDeleteBtn";
            this.itemDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.itemDeleteBtn.TabIndex = 3;
            this.itemDeleteBtn.Text = "DELETE";
            this.itemDeleteBtn.UseVisualStyleBackColor = true;
            this.itemDeleteBtn.Click += new System.EventHandler(this.itemDeleteBtn_Click);
            // 
            // itemUpdateBtn
            // 
            this.itemUpdateBtn.Location = new System.Drawing.Point(365, 156);
            this.itemUpdateBtn.Name = "itemUpdateBtn";
            this.itemUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.itemUpdateBtn.TabIndex = 4;
            this.itemUpdateBtn.Text = "UPDATE";
            this.itemUpdateBtn.UseVisualStyleBackColor = true;
            this.itemUpdateBtn.Click += new System.EventHandler(this.itemUpdateBtn_Click);
            // 
            // itemSearchBtn
            // 
            this.itemSearchBtn.Location = new System.Drawing.Point(470, 156);
            this.itemSearchBtn.Name = "itemSearchBtn";
            this.itemSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.itemSearchBtn.TabIndex = 5;
            this.itemSearchBtn.Text = "SEARCH";
            this.itemSearchBtn.UseVisualStyleBackColor = true;
            this.itemSearchBtn.Click += new System.EventHandler(this.itemSearchBtn_Click);
            // 
            // itemShowBtn
            // 
            this.itemShowBtn.Location = new System.Drawing.Point(576, 156);
            this.itemShowBtn.Name = "itemShowBtn";
            this.itemShowBtn.Size = new System.Drawing.Size(75, 23);
            this.itemShowBtn.TabIndex = 6;
            this.itemShowBtn.Text = "SHOW";
            this.itemShowBtn.UseVisualStyleBackColor = true;
            this.itemShowBtn.Click += new System.EventHandler(this.itemShowBtn_Click);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Location = new System.Drawing.Point(53, 227);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.Size = new System.Drawing.Size(877, 200);
            this.itemDataGridView.TabIndex = 7;
            this.itemDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellClick);
            // 
            // ItemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 462);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.itemShowBtn);
            this.Controls.Add(this.itemSearchBtn);
            this.Controls.Add(this.itemUpdateBtn);
            this.Controls.Add(this.itemDeleteBtn);
            this.Controls.Add(this.itemAddBtn);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ItemUi";
            this.Text = "Item Information";
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Button itemAddBtn;
        private System.Windows.Forms.Button itemDeleteBtn;
        private System.Windows.Forms.Button itemUpdateBtn;
        private System.Windows.Forms.Button itemSearchBtn;
        private System.Windows.Forms.Button itemShowBtn;
        private System.Windows.Forms.DataGridView itemDataGridView;
    }
}