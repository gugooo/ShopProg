namespace ShopProg
{
    partial class ProductGroupAddOrChange
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
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddOrChangeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(12, 48);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.CodeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Կոդ";
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Location = new System.Drawing.Point(12, 106);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(244, 23);
            this.GroupNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Անվանում";
            // 
            // AddOrChangeButton
            // 
            this.AddOrChangeButton.Location = new System.Drawing.Point(12, 172);
            this.AddOrChangeButton.Name = "AddOrChangeButton";
            this.AddOrChangeButton.Size = new System.Drawing.Size(75, 23);
            this.AddOrChangeButton.TabIndex = 2;
            this.AddOrChangeButton.Text = "Գրանցել";
            this.AddOrChangeButton.UseVisualStyleBackColor = true;
            this.AddOrChangeButton.Click += new System.EventHandler(this.AddOrChangeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(181, 172);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Փակել";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProductGroupAddOrChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 209);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddOrChangeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupNameTextBox);
            this.Controls.Add(this.CodeTextBox);
            this.Name = "ProductGroupAddOrChange";
            this.Text = "Նոր ապրանքի խումն";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddOrChangeButton;
        private System.Windows.Forms.Button CloseButton;
    }
}