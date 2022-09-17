namespace ShopProg
{
    partial class CustomerAddOrChange
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
            this.CustomerCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerLNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerDiscountTextBox = new System.Windows.Forms.TextBox();
            this.CustomerAddOrChangeButton = new System.Windows.Forms.Button();
            this.CustomerCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Կոդ";
            // 
            // CustomerCodeTextBox
            // 
            this.CustomerCodeTextBox.Location = new System.Drawing.Point(12, 62);
            this.CustomerCodeTextBox.Name = "CustomerCodeTextBox";
            this.CustomerCodeTextBox.Size = new System.Drawing.Size(75, 23);
            this.CustomerCodeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Անուն";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(12, 130);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(165, 23);
            this.CustomerNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ազգանուն";
            // 
            // CustomerLNameTextBox
            // 
            this.CustomerLNameTextBox.Location = new System.Drawing.Point(183, 130);
            this.CustomerLNameTextBox.Name = "CustomerLNameTextBox";
            this.CustomerLNameTextBox.Size = new System.Drawing.Size(165, 23);
            this.CustomerLNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Հեռախոս";
            // 
            // CustomerPhoneTextBox
            // 
            this.CustomerPhoneTextBox.Location = new System.Drawing.Point(12, 194);
            this.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
            this.CustomerPhoneTextBox.Size = new System.Drawing.Size(165, 23);
            this.CustomerPhoneTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Զեղչ";
            // 
            // CustomerDiscountTextBox
            // 
            this.CustomerDiscountTextBox.Location = new System.Drawing.Point(12, 261);
            this.CustomerDiscountTextBox.Name = "CustomerDiscountTextBox";
            this.CustomerDiscountTextBox.Size = new System.Drawing.Size(75, 23);
            this.CustomerDiscountTextBox.TabIndex = 1;
            // 
            // CustomerAddOrChangeButton
            // 
            this.CustomerAddOrChangeButton.Location = new System.Drawing.Point(12, 330);
            this.CustomerAddOrChangeButton.Name = "CustomerAddOrChangeButton";
            this.CustomerAddOrChangeButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerAddOrChangeButton.TabIndex = 2;
            this.CustomerAddOrChangeButton.Text = "Գրանցել";
            this.CustomerAddOrChangeButton.UseVisualStyleBackColor = true;
            this.CustomerAddOrChangeButton.Click += new System.EventHandler(this.CustomerAddOrChangeButton_Click);
            // 
            // CustomerCloseButton
            // 
            this.CustomerCloseButton.Location = new System.Drawing.Point(273, 330);
            this.CustomerCloseButton.Name = "CustomerCloseButton";
            this.CustomerCloseButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerCloseButton.TabIndex = 2;
            this.CustomerCloseButton.Text = "Փակել";
            this.CustomerCloseButton.UseVisualStyleBackColor = true;
            this.CustomerCloseButton.Click += new System.EventHandler(this.CustomerCloseButton_Click);
            // 
            // CustomerAddOrChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 381);
            this.Controls.Add(this.CustomerCloseButton);
            this.Controls.Add(this.CustomerAddOrChangeButton);
            this.Controls.Add(this.CustomerDiscountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerPhoneTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerLNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerCodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CustomerAddOrChange";
            this.Text = "Նոր խմբագրել";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerLNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerPhoneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerDiscountTextBox;
        private System.Windows.Forms.Button CustomerAddOrChangeButton;
        private System.Windows.Forms.Button CustomerCloseButton;
    }
}