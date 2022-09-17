using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ShopProg
{
    public partial class ProductGroupsView : Form
    {
        public ProductGroupsView()
        {
            
            InitializeComponent();
            UpdateGrid();
        }
        public async void UpdateGrid() {
            this.dataGridView1.Rows.Clear();
            var grups = await Program._ShopDBContext.grups.ToArrayAsync();
            foreach(var grup in grups)
            {
                this.dataGridView1.Rows.Add(grup.Id, grup.Code, grup.Name);
            }
            
            this.dataGridView1.Update();
        }
        private void AddNewProductGroup_Click(object sender, EventArgs e)
        {
            ProductGroupAddOrChange productAddOrChange = new ProductGroupAddOrChange();
            productAddOrChange.UpdateDataGrid += UpdateGrid;
            productAddOrChange.Show();
        }

        private void ChangeProductGroup_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var row = this.dataGridView1.SelectedRows[0];
                var id = (int)row.Cells[0].Value;
                var code= (string)row.Cells[1].Value;
                var name= (string)row.Cells[2].Value;
                ProductGroupAddOrChange productGroupAddOrChange = new ProductGroupAddOrChange(id, code, name);
                productGroupAddOrChange.UpdateDataGrid += UpdateGrid;
                productGroupAddOrChange.Show();
            }
        }

        private async void DeleteProductGroup_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var row = this.dataGridView1.SelectedRows[0];
                var id = (int)row.Cells[0].Value;
                var group = await Program._ShopDBContext.grups.FirstOrDefaultAsync(_ => _.Id == id);
                if(group != null)
                {
                    Program._ShopDBContext.grups.Remove(group);
                    await Program._ShopDBContext.SaveChangesAsync();
                    MessageBox.Show("Խումբը ժնժված է։");
                    UpdateGrid();
                }
                
            }
        }
    }
}
