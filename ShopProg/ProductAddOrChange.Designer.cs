namespace ShopProg
{
    partial class ProductAddOrChange
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
            this.ProductCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductGroupComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductAddOrChangeButton = new System.Windows.Forms.Button();
            this.ProductAddOrChangeCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Location = new System.Drawing.Point(12, 57);
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductCodeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Կոդ";
            // 
            // ProductGroupComboBox
            // 
            this.ProductGroupComboBox.FormattingEnabled = true;
            this.ProductGroupComboBox.Location = new System.Drawing.Point(12, 122);
            this.ProductGroupComboBox.Name = "ProductGroupComboBox";
            this.ProductGroupComboBox.Size = new System.Drawing.Size(121, 23);
            this.ProductGroupComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Խումբ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Անվանում";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(12, 194);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(264, 23);
            this.ProductNameTextBox.TabIndex = 0;
            // 
            // ProductAddOrChangeButton
            // 
            this.ProductAddOrChangeButton.Location = new System.Drawing.Point(12, 279);
            this.ProductAddOrChangeButton.Name = "ProductAddOrChangeButton";
            this.ProductAddOrChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ProductAddOrChangeButton.TabIndex = 4;
            this.ProductAddOrChangeButton.Text = "Գրանցել";
            this.ProductAddOrChangeButton.UseVisualStyleBackColor = true;
            this.ProductAddOrChangeButton.Click += new System.EventHandler(this.ProductAddOrChangeButton_Click);
            // 
            // ProductAddOrChangeCloseButton
            // 
            this.ProductAddOrChangeCloseButton.Location = new System.Drawing.Point(201, 279);
            this.ProductAddOrChangeCloseButton.Name = "ProductAddOrChangeCloseButton";
            this.ProductAddOrChangeCloseButton.Size = new System.Drawing.Size(75, 23);
            this.ProductAddOrChangeCloseButton.TabIndex = 4;
            this.ProductAddOrChangeCloseButton.Text = "Փակել";
            this.ProductAddOrChangeCloseButton.UseVisualStyleBackColor = true;
            this.ProductAddOrChangeCloseButton.Click += new System.EventHandler(this.ProductAddOrChangeCloseButton_Click);
            // 
            // ProductAddOrChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 327);
            this.Controls.Add(this.ProductAddOrChangeCloseButton);
            this.Controls.Add(this.ProductAddOrChangeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductGroupComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductCodeTextBox);
            this.Name = "ProductAddOrChange";
            this.Text = "ProductAddOrChange";
            this.Shown += new System.EventHandler(this.ProductAddOrChange_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductGroupComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Button ProductAddOrChangeButton;
        private System.Windows.Forms.Button ProductAddOrChangeCloseButton;
    }
}