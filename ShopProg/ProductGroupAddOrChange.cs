using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShopProg.Classes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ShopProg
{
    public partial class ProductGroupAddOrChange : Form
    {
        public event Action UpdateDataGrid;
        public int? ProductGrupId;
        public ProductGroupAddOrChange()
        {
            InitializeComponent();
        }
        public ProductGroupAddOrChange(int? productGrupId,string Code, string Name)
        {
            this.ProductGrupId = productGrupId;
            
            InitializeComponent();
            this.CodeTextBox.Text = Code;
            this.GroupNameTextBox.Text = Name;
        }

        private async void AddOrChangeButton_Click(object sender, EventArgs e)
        {
            if (ProductGrupId != null)
            {
                var group=await Program._ShopDBContext.grups.FirstOrDefaultAsync(_ => _.Id == ProductGrupId);
                group.Name = this.GroupNameTextBox.Text;
                group.Code = this.CodeTextBox.Text;
                await Program._ShopDBContext.SaveChangesAsync();
                MessageBox.Show("Փոփոխությունը կատարված է։");
                UpdateDataGrid();
            }
            else
            if (this.CodeTextBox.Text.Length != 0 && this.GroupNameTextBox.Text.Length != 0)
            {
                await Program._ShopDBContext.grups.AddAsync(new ProductGrup() { Code = this.CodeTextBox.Text, Name = this.GroupNameTextBox.Text });
                await Program._ShopDBContext.SaveChangesAsync();
                MessageBox.Show("Նոր խումբը ավելացվել է։");
                UpdateDataGrid();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
