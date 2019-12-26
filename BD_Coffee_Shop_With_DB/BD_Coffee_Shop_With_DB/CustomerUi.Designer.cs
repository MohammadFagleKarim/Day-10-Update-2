namespace BD_Coffee_Shop_With_DB
{
    partial class CustomerUi
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerContactTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerAddBtn = new System.Windows.Forms.Button();
            this.customerDeleteBtn = new System.Windows.Forms.Button();
            this.customerUpdateBtn = new System.Windows.Forms.Button();
            this.customerSearchBtn = new System.Windows.Forms.Button();
            this.customerShowBtn = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(159, 55);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(227, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact";
            // 
            // customerContactTextBox
            // 
            this.customerContactTextBox.Location = new System.Drawing.Point(159, 95);
            this.customerContactTextBox.Name = "customerContactTextBox";
            this.customerContactTextBox.Size = new System.Drawing.Size(227, 20);
            this.customerContactTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Location = new System.Drawing.Point(159, 135);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(227, 20);
            this.customerAddressTextBox.TabIndex = 1;
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Location = new System.Drawing.Point(159, 189);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(75, 23);
            this.customerAddBtn.TabIndex = 2;
            this.customerAddBtn.Text = "ADD";
            this.customerAddBtn.UseVisualStyleBackColor = true;
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // customerDeleteBtn
            // 
            this.customerDeleteBtn.Location = new System.Drawing.Point(262, 189);
            this.customerDeleteBtn.Name = "customerDeleteBtn";
            this.customerDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.customerDeleteBtn.TabIndex = 3;
            this.customerDeleteBtn.Text = "DELETE";
            this.customerDeleteBtn.UseVisualStyleBackColor = true;
            this.customerDeleteBtn.Click += new System.EventHandler(this.customerDeleteBtn_Click);
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.Location = new System.Drawing.Point(364, 189);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.customerUpdateBtn.TabIndex = 4;
            this.customerUpdateBtn.Text = "UPDATE";
            this.customerUpdateBtn.UseVisualStyleBackColor = true;
            this.customerUpdateBtn.Click += new System.EventHandler(this.customerUpdateBtn_Click);
            // 
            // customerSearchBtn
            // 
            this.customerSearchBtn.Location = new System.Drawing.Point(469, 189);
            this.customerSearchBtn.Name = "customerSearchBtn";
            this.customerSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.customerSearchBtn.TabIndex = 5;
            this.customerSearchBtn.Text = "SEARCH";
            this.customerSearchBtn.UseVisualStyleBackColor = true;
            this.customerSearchBtn.Click += new System.EventHandler(this.customerSearchBtn_Click);
            // 
            // customerShowBtn
            // 
            this.customerShowBtn.Location = new System.Drawing.Point(571, 189);
            this.customerShowBtn.Name = "customerShowBtn";
            this.customerShowBtn.Size = new System.Drawing.Size(75, 23);
            this.customerShowBtn.TabIndex = 6;
            this.customerShowBtn.Text = "SHOW";
            this.customerShowBtn.UseVisualStyleBackColor = true;
            this.customerShowBtn.Click += new System.EventHandler(this.customerShowBtn_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(90, 257);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(752, 158);
            this.customerDataGridView.TabIndex = 7;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellClick);
            // 
            // CustomerUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 466);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerShowBtn);
            this.Controls.Add(this.customerSearchBtn);
            this.Controls.Add(this.customerUpdateBtn);
            this.Controls.Add(this.customerDeleteBtn);
            this.Controls.Add(this.customerAddBtn);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerContactTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CustomerUi";
            this.Text = "Customer Information";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerContactTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.Button customerAddBtn;
        private System.Windows.Forms.Button customerDeleteBtn;
        private System.Windows.Forms.Button customerUpdateBtn;
        private System.Windows.Forms.Button customerSearchBtn;
        private System.Windows.Forms.Button customerShowBtn;
        private System.Windows.Forms.DataGridView customerDataGridView;
    }
}