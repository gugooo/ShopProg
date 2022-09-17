namespace ShopProg
{
    partial class Statement
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
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsCountInOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePriceDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ֆիլտր";
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(84, 18);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(99, 23);
            this.dateFrom.TabIndex = 1;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(189, 18);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(104, 23);
            this.dateTo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Բեռնավորել";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.ProductsCountInOrder,
            this.OrderSum,
            this.OrderDate,
            this.Customer,
            this.ProductCode,
            this.ProductGroup,
            this.ProductName,
            this.ProductCount,
            this.SalePriceDiscount,
            this.ProductSum});
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 590);
            this.dataGridView1.TabIndex = 3;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "dgId";
            this.OrderNumber.HeaderText = "Կտրոնի N";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // ProductsCountInOrder
            // 
            this.ProductsCountInOrder.DataPropertyName = "dgProductCount";
            this.ProductsCountInOrder.HeaderText = "Կտրոնում ապրանքների քանակ";
            this.ProductsCountInOrder.Name = "ProductsCountInOrder";
            this.ProductsCountInOrder.ReadOnly = true;
            // 
            // OrderSum
            // 
            this.OrderSum.DataPropertyName = "dgOrderSum";
            this.OrderSum.HeaderText = "Կտրոնի գումար";
            this.OrderSum.Name = "OrderSum";
            this.OrderSum.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "dgDate";
            this.OrderDate.HeaderText = "Ամսատիվ";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "dgCustomer";
            this.Customer.HeaderText = "Գնորդ";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "dgProductCode";
            this.ProductCode.HeaderText = "Ապրանքի կոդ";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductGroup
            // 
            this.ProductGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductGroup.DataPropertyName = "dgProductGroup";
            this.ProductGroup.HeaderText = "Ապրանքի խումբ";
            this.ProductGroup.Name = "ProductGroup";
            this.ProductGroup.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "dgProductName";
            this.ProductName.HeaderText = "Անվանում";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCount
            // 
            this.ProductCount.DataPropertyName = "dgProductCountinItem";
            this.ProductCount.HeaderText = "Քանակ";
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.ReadOnly = true;
            // 
            // SalePriceDiscount
            // 
            this.SalePriceDiscount.DataPropertyName = "dgProductPriceDiscount";
            this.SalePriceDiscount.HeaderText = "Վաճառքի գին զեղչված";
            this.SalePriceDiscount.Name = "SalePriceDiscount";
            this.SalePriceDiscount.ReadOnly = true;
            // 
            // ProductSum
            // 
            this.ProductSum.DataPropertyName = "dgOrderItemSum";
            this.ProductSum.HeaderText = "Գումար";
            this.ProductSum.Name = "ProductSum";
            this.ProductSum.ReadOnly = true;
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label1);
            this.Name = "Statement";
            this.Text = "Statement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsCountInOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePriceDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSum;
    }
}