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
    public partial class ProductsPackingList : Form
    {
        public ProductsPackingList()
        {
            InitializeComponent();
        }
        private async void initForm()
        {
            var orders = Program._ShopDBContext.orderItems.
                Include(_ => _.Product)
                .Include(_ => _.Order)
                .Where(_ => _.Order != null).AsEnumerable().GroupBy(_ => _.Product);

            var items = Program._ShopDBContext.supplierProductListItems
                .Include(_ => _.Product).ThenInclude(_ => _.ProductGrup)
                .Include(_ => _.Supplier)
                .Where(_ => _.Supplier != null).AsEnumerable().GroupBy(_ => _.Product)
                .Join(orders, s => s.Key, o => o.Key, (s, o) => new
                {
                    dgProductId = s.Key.Id,
                    dgCode = s.Key.Code,
                    dgName = s.Key.Name,
                    dgGroupName = s.Key.ProductGrup.Name,
                    dgProductCount = s.Sum(c => c.ProductCount) - o.Sum(os => os.ProductCount),
                    dgProductPrice = s.Average(c => c.ProductPrice * (1 + c.ProductProfit / 100))
                }).ToList();

            dataGridView1.DataSource = items;
        }

        private void ProductsPackingList_Shown(object sender, EventArgs e)
        {
            initForm();
        }
    }
}
