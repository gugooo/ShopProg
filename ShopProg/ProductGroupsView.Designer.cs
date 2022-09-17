namespace ShopProg
{
    partial class ProductGroupsView
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
            this.AddNewProductGroup = new System.Windows.Forms.Button();
            this.ChangeProductGroup = new System.Windows.Forms.Button();
            this.DeleteProductGroup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewProductGroup
            // 
            this.AddNewProductGroup.Location = new System.Drawing.Point(12, 12);
            this.AddNewProductGroup.Name = "AddNewProductGroup";
            this.AddNewProductGroup.Size = new System.Drawing.Size(89, 23);
            this.AddNewProductGroup.TabIndex = 0;
            this.AddNewProductGroup.Text = "Ավելացնել";
            this.AddNewProductGroup.UseVisualStyleBackColor = true;
            this.AddNewProductGroup.Click += new System.EventHandler(this.AddNewProductGroup_Click);
            // 
            // ChangeProductGroup
            // 
            this.ChangeProductGroup.Location = new System.Drawing.Point(107, 12);
            this.ChangeProductGroup.Name = "ChangeProductGroup";
            this.ChangeProductGroup.Size = new System.Drawing.Size(75, 23);
            this.ChangeProductGroup.TabIndex = 0;
            this.ChangeProductGroup.Text = "Փոփոխել";
            this.ChangeProductGroup.UseVisualStyleBackColor = true;
            this.ChangeProductGroup.Click += new System.EventHandler(this.ChangeProductGroup_Click);
            // 
            // DeleteProductGroup
            // 
            this.DeleteProductGroup.Location = new System.Drawing.Point(188, 12);
            this.DeleteProductGroup.Name = "DeleteProductGroup";
            this.DeleteProductGroup.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductGroup.TabIndex = 0;
            this.DeleteProductGroup.Text = "Ժնժել";
            this.DeleteProductGroup.UseVisualStyleBackColor = true;
            this.DeleteProductGroup.Click += new System.EventHandler(this.DeleteProductGroup_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.GroupCodeColumn,
            this.GroupNameColumn});
            this.dataGridView1.Location = new System.Drawing.Point(20, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // GroupCodeColumn
            // 
            this.GroupCodeColumn.HeaderText = "Կոդ";
            this.GroupCodeColumn.Name = "GroupCodeColumn";
            this.GroupCodeColumn.ReadOnly = true;
            // 
            // GroupNameColumn
            // 
            this.GroupNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GroupNameColumn.HeaderText = "Անվանում";
            this.GroupNameColumn.Name = "GroupNameColumn";
            this.GroupNameColumn.ReadOnly = true;
            // 
            // ProductGroupsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteProductGroup);
            this.Controls.Add(this.ChangeProductGroup);
            this.Controls.Add(this.AddNewProductGroup);
            this.Name = "ProductGroupsView";
            this.Text = "Ապրանքների Խումբ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewProductGroup;
        private System.Windows.Forms.Button ChangeProductGroup;
        private System.Windows.Forms.Button DeleteProductGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameColumn;
    }
}