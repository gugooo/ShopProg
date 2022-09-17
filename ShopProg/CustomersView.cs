using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShopProg.Classes;

namespace ShopProg
{
    public partial class CustomersView : Form
    {
        public CustomersView()
        {
            InitializeComponent();
            UpdateGrid();
        }
        public async void UpdateGrid()
        {
            this.dataGridView1.DataSource = await Program._ShopDBContext.customers.ToListAsync();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerAddOrChange customerAddOrChange = new CustomerAddOrChange();
            customerAddOrChange.dataGridUpdateEvent += UpdateGrid;
            customerAddOrChange.Show();
        }

        private async void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var row = this.dataGridView1.SelectedRows[0];
                var id = (int)row.Cells[0].Value;
                var customer = await Program._ShopDBContext.customers.FirstOrDefaultAsync(_ => _.Id == id);
                if (customer != null)
                {
                    Program._ShopDBContext.customers.Remove(customer);
                    await Program._ShopDBContext.SaveChangesAsync();
                    MessageBox.Show("Գնորդը ժնժված է։");
                    UpdateGrid();
                }

            }
        }

        private void ChangeCustomerButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var row = this.dataGridView1.SelectedRows[0];
                var id = (int)row.Cells[0].Value;
                CustomerAddOrChange productGroupAddOrChange = new CustomerAddOrChange(id);
                productGroupAddOrChange.dataGridUpdateEvent += UpdateGrid;
                productGroupAddOrChange.Show();
            }
        }
    }
}
