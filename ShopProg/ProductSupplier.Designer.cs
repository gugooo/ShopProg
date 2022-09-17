namespace ShopProg
{
    partial class ProductSupplier
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DocumentTab = new System.Windows.Forms.TabPage();
            this.DocumentSumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuplierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DocumentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsListTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductProfitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSalePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductValidDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductValidDate = new System.Windows.Forms.DateTimePicker();
            this.ProductSum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SalePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductProfit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.DocumentTab.SuspendLayout();
            this.ProductsListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DocumentTab);
            this.tabControl1.Controls.Add(this.ProductsListTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // DocumentTab
            // 
            this.DocumentTab.Controls.Add(this.DocumentSumTextBox);
            this.DocumentTab.Controls.Add(this.label3);
            this.DocumentTab.Controls.Add(this.SuplierName);
            this.DocumentTab.Controls.Add(this.label2);
            this.DocumentTab.Controls.Add(this.DocumentNumberTextBox);
            this.DocumentTab.Controls.Add(this.label1);
            this.DocumentTab.Location = new System.Drawing.Point(4, 24);
            this.DocumentTab.Name = "DocumentTab";
            this.DocumentTab.Padding = new System.Windows.Forms.Padding(3);
            this.DocumentTab.Size = new System.Drawing.Size(1019, 578);
            this.DocumentTab.TabIndex = 0;
            this.DocumentTab.Text = "Փաստաթղթի տվյալներ";
            this.DocumentTab.UseVisualStyleBackColor = true;
            // 
            // DocumentSumTextBox
            // 
            this.DocumentSumTextBox.Location = new System.Drawing.Point(6, 183);
            this.DocumentSumTextBox.Name = "DocumentSumTextBox";
            this.DocumentSumTextBox.ReadOnly = true;
            this.DocumentSumTextBox.Size = new System.Drawing.Size(130, 23);
            this.DocumentSumTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Փաստաթղթի գումար";
            // 
            // SuplierName
            // 
            this.SuplierName.Location = new System.Drawing.Point(6, 117);
            this.SuplierName.Name = "SuplierName";
            this.SuplierName.Size = new System.Drawing.Size(199, 23);
            this.SuplierName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Մատակարար";
            // 
            // DocumentNumberTextBox
            // 
            this.DocumentNumberTextBox.Location = new System.Drawing.Point(6, 54);
            this.DocumentNumberTextBox.Name = "DocumentNumberTextBox";
            this.DocumentNumberTextBox.Size = new System.Drawing.Size(130, 23);
            this.DocumentNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Փաստաթղթի N";
            // 
            // ProductsListTab
            // 
            this.ProductsListTab.Controls.Add(this.dataGridView1);
            this.ProductsListTab.Controls.Add(this.button1);
            this.ProductsListTab.Controls.Add(this.ProductValidDate);
            this.ProductsListTab.Controls.Add(this.ProductSum);
            this.ProductsListTab.Controls.Add(this.label9);
            this.ProductsListTab.Controls.Add(this.SalePrice);
            this.ProductsListTab.Controls.Add(this.label8);
            this.ProductsListTab.Controls.Add(this.ProductProfit);
            this.ProductsListTab.Controls.Add(this.label7);
            this.ProductsListTab.Controls.Add(this.ProductPrice);
            this.ProductsListTab.Controls.Add(this.label6);
            this.ProductsListTab.Controls.Add(this.ProductCount);
            this.ProductsListTab.Controls.Add(this.label5);
            this.ProductsListTab.Controls.Add(this.label10);
            this.ProductsListTab.Controls.Add(this.label4);
            this.ProductsListTab.Controls.Add(this.comboBox1);
            this.ProductsListTab.Location = new System.Drawing.Point(4, 24);
            this.ProductsListTab.Name = "ProductsListTab";
            this.ProductsListTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsListTab.Size = new System.Drawing.Size(1019, 578);
            this.ProductsListTab.TabIndex = 1;
            this.ProductsListTab.Text = "Ապրանքների ցանկ";
            this.ProductsListTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductNameColumn,
            this.ProductCountColumn,
            this.ProductPriceColumn,
            this.ProductSumColumn,
            this.ProductProfitColumn,
            this.ProductSalePriceColumn,
            this.ProductValidDateColumn});
            this.dataGridView1.Location = new System.Drawing.Point(7, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 477);
            this.dataGridView1.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNameColumn.DataPropertyName = "ProductName";
            this.ProductNameColumn.HeaderText = "Ապրանքի անվանում";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // ProductCountColumn
            // 
            this.ProductCountColumn.DataPropertyName = "ProductCount";
            this.ProductCountColumn.HeaderText = "Քանակ";
            this.ProductCountColumn.Name = "ProductCountColumn";
            this.ProductCountColumn.ReadOnly = true;
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.DataPropertyName = "ProductPrice";
            this.ProductPriceColumn.HeaderText = "Գին";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            this.ProductPriceColumn.ReadOnly = true;
            // 
            // ProductSumColumn
            // 
            this.ProductSumColumn.DataPropertyName = "ProductSum";
            this.ProductSumColumn.HeaderText = "Գումար";
            this.ProductSumColumn.Name = "ProductSumColumn";
            this.ProductSumColumn.ReadOnly = true;
            // 
            // ProductProfitColumn
            // 
            this.ProductProfitColumn.DataPropertyName = "ProductProfit";
            this.ProductProfitColumn.HeaderText = "Վերադիր %";
            this.ProductProfitColumn.Name = "ProductProfitColumn";
            this.ProductProfitColumn.ReadOnly = true;
            // 
            // ProductSalePriceColumn
            // 
            this.ProductSalePriceColumn.DataPropertyName = "SalePrice";
            this.ProductSalePriceColumn.HeaderText = "Վաճառքի գին";
            this.ProductSalePriceColumn.Name = "ProductSalePriceColumn";
            this.ProductSalePriceColumn.ReadOnly = true;
            // 
            // ProductValidDateColumn
            // 
            this.ProductValidDateColumn.DataPropertyName = "ProductValidDate";
            this.ProductValidDateColumn.HeaderText = "Պիտ․ ժամկետ";
            this.ProductValidDateColumn.Name = "ProductValidDateColumn";
            this.ProductValidDateColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Գրանցել";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductValidDate
            // 
            this.ProductValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ProductValidDate.Location = new System.Drawing.Point(556, 52);
            this.ProductValidDate.Name = "ProductValidDate";
            this.ProductValidDate.Size = new System.Drawing.Size(84, 23);
            this.ProductValidDate.TabIndex = 3;
            // 
            // ProductSum
            // 
            this.ProductSum.Enabled = false;
            this.ProductSum.Location = new System.Drawing.Point(265, 52);
            this.ProductSum.Name = "ProductSum";
            this.ProductSum.Size = new System.Drawing.Size(100, 23);
            this.ProductSum.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Գումար";
            // 
            // SalePrice
            // 
            this.SalePrice.Enabled = false;
            this.SalePrice.Location = new System.Drawing.Point(450, 52);
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Size = new System.Drawing.Size(100, 23);
            this.SalePrice.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Վաճառքի գին";
            // 
            // ProductProfit
            // 
            this.ProductProfit.Location = new System.Drawing.Point(371, 52);
            this.ProductProfit.Name = "ProductProfit";
            this.ProductProfit.Size = new System.Drawing.Size(73, 23);
            this.ProductProfit.TabIndex = 2;
            this.ProductProfit.TextChanged += new System.EventHandler(this.ProductProfit_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Վերադիր %";
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(194, 52);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(65, 23);
            this.ProductPrice.TabIndex = 2;
            this.ProductPrice.TextChanged += new System.EventHandler(this.ProductPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Գին";
            // 
            // ProductCount
            // 
            this.ProductCount.Location = new System.Drawing.Point(139, 52);
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Size = new System.Drawing.Size(49, 23);
            this.ProductCount.TabIndex = 2;
            this.ProductCount.TextChanged += new System.EventHandler(this.ProductCount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Քանակ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Պիտ ժամկետ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ապրանքի անվանում";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Գրանցել";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(960, 624);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Փակել";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 690);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductSupplier";
            this.Text = "Ապրանքների ձեռք բերում";
            this.tabControl1.ResumeLayout(false);
            this.DocumentTab.ResumeLayout(false);
            this.DocumentTab.PerformLayout();
            this.ProductsListTab.ResumeLayout(false);
            this.ProductsListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DocumentTab;
        private System.Windows.Forms.TextBox DocumentSumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SuplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DocumentNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ProductsListTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker ProductValidDate;
        private System.Windows.Forms.TextBox ProductSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SalePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProductProfit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductProfitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSalePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductValidDateColumn;
    }
}