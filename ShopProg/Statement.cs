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
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await Program._ShopDBContext.orderItems
                .Include(_ => _.Product).ThenInclude(_ => _.ProductGrup)
                .Include(_ => _.Order).ThenInclude(_ => _.Items)
                .Include(_ => _.Customer)
                .Where(_ => _.Order.CreatedDate >= dateFrom.Value && _.Order.CreatedDate <= dateTo.Value)
                .Select(_ => new
                {
                    dgId = _.Order.Id,
                    dgProductCount = _.Order.Items.Sum(i => i.ProductCount),
                    dgOrderSum = _.Order.Items.Sum(i => i.ProductCount * i.ProductPrice * (1 - i.ProductDiscount / 100)),
                    dgDate = _.Order.CreatedDate,
                    dgCustomer = _.Customer.Code,
                    dgProductCode = _.Product.Code,
                    dgProductGroup = _.Product.ProductGrup.Name,
                    dgProductName = _.Product.Name,
                    dgProductCountinItem = _.ProductCount,
                    dgProductPriceDiscount = _.ProductPrice * (1 - _.ProductDiscount / 100),
                    dgOrderItemSum = _.ProductCount * _.ProductPrice * (1 - _.ProductDiscount / 100),
                }).ToListAsync();
        }
    }
}
