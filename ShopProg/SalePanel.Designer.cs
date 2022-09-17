namespace ShopProg
{
    partial class SalePanel
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
            this.ProductGroupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductCountTextBox = new System.Windows.Forms.TextBox();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductSaleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductDiscountPriceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductSumeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerCodeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerDiscountTextBox = new System.Windows.Forms.TextBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddOrderItemTB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGroupComboBox
            // 
            this.ProductGroupComboBox.FormattingEnabled = true;
            this.ProductGroupComboBox.Location = new System.Drawing.Point(12, 45);
            this.ProductGroupComboBox.Name = "ProductGroupComboBox";
            this.ProductGroupComboBox.Size = new System.Drawing.Size(121, 23);
            this.ProductGroupComboBox.TabIndex = 0;
            this.ProductGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductGroupComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ապրանքի խումբ";
            // 
            // ProductCountTextBox
            // 
            this.ProductCountTextBox.Location = new System.Drawing.Point(170, 79);
            this.ProductCountTextBox.Name = "ProductCountTextBox";
            this.ProductCountTextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductCountTextBox.TabIndex = 2;
            this.ProductCountTextBox.TextChanged += new System.EventHandler(this.ProductCountTextBox_TextChanged);
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(12, 116);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(121, 23);
            this.ProductComboBox.TabIndex = 0;
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ապրանքի անվանում";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Քանակ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Վաճառքի գին";
            // 
            // ProductSaleTextBox
            // 
            this.ProductSaleTextBox.Enabled = false;
            this.ProductSaleTextBox.Location = new System.Drawing.Point(276, 79);
            this.ProductSaleTextBox.Name = "ProductSaleTextBox";
            this.ProductSaleTextBox.ReadOnly = true;
            this.ProductSaleTextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductSaleTextBox.TabIndex = 2;
            this.ProductSaleTextBox.TextChanged += new System.EventHandler(this.ProductSaleTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Զեղչված գին";
            // 
            // ProductDiscountPriceTB
            // 
            this.ProductDiscountPriceTB.Enabled = false;
            this.ProductDiscountPriceTB.Location = new System.Drawing.Point(382, 79);
            this.ProductDiscountPriceTB.Name = "ProductDiscountPriceTB";
            this.ProductDiscountPriceTB.ReadOnly = true;
            this.ProductDiscountPriceTB.Size = new System.Drawing.Size(100, 23);
            this.ProductDiscountPriceTB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Գումար";
            // 
            // ProductSumeTextBox
            // 
            this.ProductSumeTextBox.Enabled = false;
            this.ProductSumeTextBox.Location = new System.Drawing.Point(488, 79);
            this.ProductSumeTextBox.Name = "ProductSumeTextBox";
            this.ProductSumeTextBox.ReadOnly = true;
            this.ProductSumeTextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductSumeTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Կտրոնի N";
            // 
            // CustomerCodeTextBox
            // 
            this.CustomerCodeTextBox.Enabled = false;
            this.CustomerCodeTextBox.Location = new System.Drawing.Point(12, 188);
            this.CustomerCodeTextBox.Name = "CustomerCodeTextBox";
            this.CustomerCodeTextBox.ReadOnly = true;
            this.CustomerCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.CustomerCodeTextBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Գնորդի զեղչ";
            // 
            // CustomerDiscountTextBox
            // 
            this.CustomerDiscountTextBox.Enabled = false;
            this.CustomerDiscountTextBox.Location = new System.Drawing.Point(245, 188);
            this.CustomerDiscountTextBox.Name = "CustomerDiscountTextBox";
            this.CustomerDiscountTextBox.ReadOnly = true;
            this.CustomerDiscountTextBox.Size = new System.Drawing.Size(100, 23);
            this.CustomerDiscountTextBox.TabIndex = 2;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(118, 188);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(121, 23);
            this.CustomerComboBox.TabIndex = 0;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Գնորդ";
            // 
            // AddOrderItemTB
            // 
            this.AddOrderItemTB.Location = new System.Drawing.Point(616, 79);
            this.AddOrderItemTB.Name = "AddOrderItemTB";
            this.AddOrderItemTB.Size = new System.Drawing.Size(75, 23);
            this.AddOrderItemTB.TabIndex = 3;
            this.AddOrderItemTB.Text = "Գրանցել";
            this.AddOrderItemTB.UseVisualStyleBackColor = true;
            this.AddOrderItemTB.Click += new System.EventHandler(this.AddOrderItemTB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Գրանցել";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(782, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Փակել";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNameColumn.DataPropertyName = "dgName";
            this.ProductNameColumn.HeaderText = "Ապրանքի անվանում";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dgName,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(845, 322);
            this.dataGridView1.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dgName
            // 
            this.dgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgName.DataPropertyName = "dgName";
            this.dgName.HeaderText = "Ապրանքի անվանում";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dgCount";
            this.Column1.HeaderText = "Քանակ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dgPrice";
            this.Column2.HeaderText = "Վաճառքի գին";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dgDiscount";
            this.Column3.HeaderText = "Զեղչ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dgDiscountPrice";
            this.Column4.HeaderText = "Զեղչված գին";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DgSum";
            this.Column5.HeaderText = "Գումար";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // SalePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 617);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddOrderItemTB);
            this.Controls.Add(this.CustomerDiscountTextBox);
            this.Controls.Add(this.CustomerCodeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductSumeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductDiscountPriceTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductSaleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductCountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.ProductGroupComboBox);
            this.Name = "SalePanel";
            this.Text = "Վաճառք";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductGroupComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductCountTextBox;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductSaleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductDiscountPriceTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductSumeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustomerCodeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustomerDiscountTextBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddOrderItemTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}