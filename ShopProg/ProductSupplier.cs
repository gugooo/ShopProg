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
    public partial class ProductSupplier : Form
    {
        public ProductSupplier()
        {
            InitializeComponent();
            formInit();
        }
        public async void formInit()
        {
            var products = await Program._ShopDBContext.products.Select(_ => new ComboboxItem() { Text = _.Name, Value = _.Id }).ToListAsync();
            foreach (var product in products)
            {
                this.comboBox1.Items.Add(product);
            }
            if (this.comboBox1.Items.Count > 0) this.comboBox1.SelectedIndex = 0;
            gridUpdate();
        }
        public async void gridUpdate()
        {
            var items = await Program._ShopDBContext.supplierProductListItems.Include(_=>_.Product).Include(_ => _.Supplier).Where(_ => _.Supplier == null).ToListAsync();
            this.dataGridView1.DataSource = items.Select(_ => new
            {
                Id=_.ID,
                ProductName = _.Product.Name,
                ProductCount=_.ProductCount,
                ProductPrice = _.ProductPrice,
                ProductSum=_.ProductPrice*_.ProductCount,
                ProductProfit= _.ProductProfit,
                SalePrice=_.ProductPrice*(1+_.ProductProfit/100),
                ProductValidDate=_.ProductValidDate
            }).ToList();
            documentSumUpdate();
        }
        public async void documentSumUpdate()
        {
            var items = await Program._ShopDBContext.supplierProductListItems.Include(_=>_.Supplier).Where(_=>_.Supplier==null).ToListAsync();
            if (items.Count > 0)
            {
                this.DocumentSumTextBox.Text = items.Sum(_ => _.ProductCount * _.ProductPrice).ToString();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int? productId = (this.comboBox1.SelectedItem as ComboboxItem).Value;
            bool countIsCorrect = int.TryParse(this.ProductCount.Text, out int count);
            bool priceIsCorrect = decimal.TryParse(this.ProductPrice.Text, out decimal price);
            bool profitIsCorrect= decimal.TryParse(this.ProductProfit.Text, out decimal profit);
            DateTime date = this.ProductValidDate.Value;
            if(productId.HasValue && countIsCorrect && priceIsCorrect && profitIsCorrect)
            {
                var product = await Program._ShopDBContext.products.FirstOrDefaultAsync(_ => _.Id == productId);
                if(product != null)
                {
                    await Program._ShopDBContext.supplierProductListItems.AddAsync(new SupplierProductListItem()
                    {
                        Product = product,
                        ProductCount=count,
                        ProductPrice=price,
                        ProductProfit=profit,
                        ProductValidDate=date
                    });
                    await Program._ShopDBContext.SaveChangesAsync();
                    MessageBox.Show("Ապրանք ավելացված է ցանկում։");
                    this.gridUpdate();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string document = this.DocumentNumberTextBox.Text;
            string supplier = this.SuplierName.Text;
            var items = await Program._ShopDBContext.supplierProductListItems.Include(_ => _.Supplier).Where(_ => _.Supplier == null).ToListAsync();
            if(document.Length > 0 && supplier.Length > 0 && items.Count > 0)
            {
                await Program._ShopDBContext.suppliers.AddAsync(new Supplier() { DocumentNumber = document, Name = supplier, ProductListItems = items });
                await Program._ShopDBContext.SaveChangesAsync();
                MessageBox.Show("Նոր բեռնաքանակը մուտքագրված է։");
                gridUpdate();
                this.DocumentSumTextBox.Text = "";
            }
        }

        private void ProductCount_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(ProductCount.Text, out decimal count) && decimal.TryParse(ProductPrice.Text,out decimal price))
            {
                ProductSum.Text = (count * price).ToString();
            }
        }

        private void ProductPrice_TextChanged(object sender, EventArgs e)
        {
            var priceIsCorrect = decimal.TryParse(ProductPrice.Text, out decimal price);
            if (decimal.TryParse(ProductCount.Text, out decimal count) && priceIsCorrect)
            {
                ProductSum.Text = (count * price).ToString();
            }
            if(priceIsCorrect && decimal.TryParse(ProductProfit.Text, out decimal profit))
            {
                SalePrice.Text = ((1 + profit / 100) * price).ToString();
            }
        }

        private void ProductProfit_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(ProductProfit.Text, out decimal profit) && decimal.TryParse(ProductPrice.Text, out decimal price))
            {
                SalePrice.Text = ((1 + profit / 100) * price).ToString();
            }
        }
    }

}
