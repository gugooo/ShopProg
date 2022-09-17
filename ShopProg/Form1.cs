using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductGroupsView productGroupsView = new ProductGroupsView();
            productGroupsView.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ProductsView productsView = new ProductsView();
            productsView.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CustomersView customersView = new CustomersView();
            customersView.Show();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProductSupplier productSupplier = new ProductSupplier();
            productSupplier.Show();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalePanel salePanel = new SalePanel();
            salePanel.Show();
        }

        private void SaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalePanel salePanel1 = new SalePanel();
            salePanel1.Show();
        }

        private void StoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsPackingList productsPackingList = new ProductsPackingList();
            productsPackingList.Show();
        }

        private void StatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statement statement = new Statement();
            statement.Show();
        }
    }
}
