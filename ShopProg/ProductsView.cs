using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ShopProg
{
    public partial class ProductsView : Form
    {
        public ProductsView()
        {
            InitializeComponent();
            UpdateGrid();
        }

        public async void UpdateGrid()
        {
            this.dataGridView1.Rows.Clear();
            var products = await Program._ShopDBContext.products.Include(_ => _.ProductGrup).ToListAsync();
            foreach (var product in products)
            {
                this.dataGridView1.Rows.Add(product.Id, product.Code, product.ProductGrup.Name, product.Name);
            }
            this.dataGridView1.Update();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductAddOrChange product = new ProductAddOrChange();
            product.UpdateDataGrid += UpdateGrid;
            product.Show();
        }

        private async void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var row = this.dataGridView1.SelectedRows[0];
                var id = (int)row.Cells[0].Value;
                var product = await Program._ShopDBContext.products.FirstOrDefaultAsync(_ => _.Id == id);
                if (product != null)
                {
                    Program._ShopDBContext.products.Remove(product);
                    await Program._ShopDBContext.SaveChangesAsync();
                    MessageBox.Show("Ապրանքը ժնժված է։");
                    UpdateGrid();
                }

            }
        }

        private void ChangeProductButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var row = this.dataGridView1.SelectedRows[0];
                var id = (int)row.Cells[0].Value;

                ProductAddOrChange product = new ProductAddOrChange();
                product.UpdateDataGrid += UpdateGrid;
                product.ProductIsChange = id;
                product.Show();
            }
        }
    }
}
