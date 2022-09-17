namespace ShopProg
{
    partial class ProductsView
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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ChangeProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(12, 12);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(90, 23);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Ավելացնել";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ChangeProductButton
            // 
            this.ChangeProductButton.Location = new System.Drawing.Point(108, 12);
            this.ChangeProductButton.Name = "ChangeProductButton";
            this.ChangeProductButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeProductButton.TabIndex = 0;
            this.ChangeProductButton.Text = "Փոփոխել";
            this.ChangeProductButton.UseVisualStyleBackColor = true;
            this.ChangeProductButton.Click += new System.EventHandler(this.ChangeProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(189, 12);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 0;
            this.DeleteProductButton.Text = "Ժնյել";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProductCodeColumn,
            this.ProductGroupNameColumn,
            this.ProductColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 374);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ProductCodeColumn
            // 
            this.ProductCodeColumn.HeaderText = "Կոդ";
            this.ProductCodeColumn.Name = "ProductCodeColumn";
            this.ProductCodeColumn.ReadOnly = true;
            // 
            // ProductGroupNameColumn
            // 
            this.ProductGroupNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductGroupNameColumn.HeaderText = "Խումբ";
            this.ProductGroupNameColumn.Name = "ProductGroupNameColumn";
            this.ProductGroupNameColumn.ReadOnly = true;
            // 
            // ProductColumn
            // 
            this.ProductColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductColumn.HeaderText = "Անվանում";
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.ReadOnly = true;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ChangeProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Name = "ProductsView";
            this.Text = "Ապրանքների անվանումների ցուցակ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ChangeProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGroupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
    }
}