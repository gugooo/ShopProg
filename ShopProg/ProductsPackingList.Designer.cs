namespace ShopProg
{
    partial class ProductsPackingList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Code,
            this.ProductGroupNameColumn,
            this.ProductNameColumne,
            this.ProductCountColumn,
            this.ProductPriceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ավելացնել";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(110, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Փոփոխել";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(191, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ժնժել";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "dgProductId";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "dgCode";
            this.Code.HeaderText = "Կոդ";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // ProductGroupNameColumn
            // 
            this.ProductGroupNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductGroupNameColumn.DataPropertyName = "dgGroupName";
            this.ProductGroupNameColumn.HeaderText = "Խումբ";
            this.ProductGroupNameColumn.Name = "ProductGroupNameColumn";
            this.ProductGroupNameColumn.ReadOnly = true;
            // 
            // ProductNameColumne
            // 
            this.ProductNameColumne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNameColumne.DataPropertyName = "dgName";
            this.ProductNameColumne.HeaderText = "Անվանում";
            this.ProductNameColumne.Name = "ProductNameColumne";
            this.ProductNameColumne.ReadOnly = true;
            // 
            // ProductCountColumn
            // 
            this.ProductCountColumn.DataPropertyName = "dgProductCount";
            this.ProductCountColumn.HeaderText = "Քանակ";
            this.ProductCountColumn.Name = "ProductCountColumn";
            this.ProductCountColumn.ReadOnly = true;
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.DataPropertyName = "dgProductPrice";
            this.ProductPriceColumn.HeaderText = "Գին";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            this.ProductPriceColumn.ReadOnly = true;
            // 
            // ProductsPackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductsPackingList";
            this.Text = "Ապրանքների անվանումների ցուցակ";
            this.Shown += new System.EventHandler(this.ProductsPackingList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGroupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
    }
}