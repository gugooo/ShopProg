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
using System.Threading.Tasks;

namespace ShopProg
{
    public partial class SalePanel : Form
    {
        private decimal customerDiscount;
        private decimal productAveragePrice;
        private int productCount;
        private decimal productDiscountPrice { get { return (productAveragePrice * (1 - customerDiscount / 100)); } }
        public SalePanel()
        {
            InitializeComponent();
            formInit();
        }
        async void formInit()
        {
            var items = await Program._ShopDBContext.grups.Select(_ => new ComboboxItem() { Text = _.Name, Value = _.Id }).ToListAsync();
            if (items.Count > 0)
            {
                foreach (var item in items)
                {
                    this.ProductGroupComboBox.Items.Add(item);
                }
            }

            var customers = await Program._ShopDBContext.customers.Select(_ => new ComboboxItem { Text = _.Name, Value = _.Id }).ToListAsync();
            if (customers.Count > 0)
            {
                foreach (var customer in customers)
                {
                    CustomerComboBox.Items.Add(customer);
                }
                this.CustomerComboBox.SelectedIndex = 0;
            }
            await updateGrid();
            if (items.Count > 0) this.ProductGroupComboBox.SelectedIndex = 0;
        }

        private async void ProductGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int groupId = (this.ProductGroupComboBox.SelectedItem as ComboboxItem).Value;
            //var products = await Program._ShopDBContext.products.Include(_=>_.ProductGrup).Where(_ => _.ProductGrup.Id == groupId).ToListAsync();
            var products = await Program._ShopDBContext.supplierProductListItems
                .Include(_ => _.Product)
                .Include(_ => _.Product).ThenInclude(_ => _.ProductGrup)
                .Select(_ => _.Product).Where(_ => _.ProductGrup.Id == groupId).Distinct().ToListAsync();
            if(products.Count > 0)
            {
                var items = products.Select(_ => new ComboboxItem() { Text = _.Name, Value = _.Id }).ToList();
                this.ProductComboBox.Items.Clear();
                foreach (var item in items)
                {
                    this.ProductComboBox.Items.Add(item);
                }
                this.ProductComboBox.SelectedIndex = 0;
            }
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int customerId = (this.CustomerComboBox.SelectedItem as ComboboxItem).Value;
            var customer = Program._ShopDBContext.customers.FirstOrDefault(_ => _.Id == customerId);
            if(customer != null)
            {
                CustomerDiscountTextBox.Text = customer.Discount.ToString();
                customerDiscount=customer.Discount;
                CustomerCodeTextBox.Text = customer.Code;
                ProductDiscountPriceTB.Text = productDiscountPrice.ToString();
                if (productCount > 0) ProductSumeTextBox.Text = (productCount * productDiscountPrice).ToString();
            }
        }

        private void ProductCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProductCountTextBox.Text, out int count))
            {
                this.productCount=count;
                ProductSaleTextBox.Text = productAveragePrice.ToString();
                ProductSumeTextBox.Text = (productDiscountPrice * count).ToString();
            }
            else
            {
                ProductSumeTextBox.Text = "";
            }
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = (this.ProductComboBox.SelectedItem as ComboboxItem).Value;
            var items = Program._ShopDBContext.supplierProductListItems.Include(_ => _.Product).Where(_ => _.Product.Id == productId).ToList();
            if (items.Count > 0) this.productAveragePrice = items.Average(_ => _.ProductPrice * (1 + _.ProductProfit / 100));
            ProductSaleTextBox.Text = productAveragePrice.ToString();
            ProductDiscountPriceTB.Text = productDiscountPrice.ToString();
        }

        private async void AddOrderItemTB_Click(object sender, EventArgs e)
        {
            int productId = (this.ProductComboBox.SelectedItem as ComboboxItem).Value;
            int productCountInSupplier = await Program._ShopDBContext.supplierProductListItems.Include(_ => _.Product).Where(_ => _.Product.Id == productId).SumAsync(_ => _.ProductCount);
            int productSalesCount = await Program._ShopDBContext.orderItems.Include(_ => _.Product).Where(_ => _.Product.Id == productId).SumAsync(_ => _.ProductCount);
            if (productCountInSupplier > 0 && productSalesCount >= 0 && productCountInSupplier - productSalesCount < productCount)
            {
                MessageBox.Show($"Առավելագույն ապրանքի քանակը {productCountInSupplier - productSalesCount}");
                return;
            }
            var product = await Program._ShopDBContext.products.FirstOrDefaultAsync(_=>_.Id==productId);
            int customerId = (this.CustomerComboBox.SelectedItem as ComboboxItem).Value;
            var customer = Program._ShopDBContext.customers.FirstOrDefault(_ => _.Id == customerId);
            if (product != null && productCount > 0 && productAveragePrice > 0 && customer != null) 
            {
                await Program._ShopDBContext.orderItems.AddAsync(new OrderItem()
                {
                    Product = product,
                    ProductCount = productCount,
                    ProductDiscount = customerDiscount,
                    ProductPrice = productAveragePrice,
                    Customer = customer
                });
                await Program._ShopDBContext.SaveChangesAsync();
                await updateGrid();
            }
        }
        async Task updateGrid()
        {
            var orders = await Program._ShopDBContext.orderItems.Include(_ => _.Product).Include(_ => _.Order).Where(_ => _.Order == null).ToListAsync();
            this.dataGridView1.DataSource = orders.Select(_ => new
            {
                id = _.Id,
                dgName = _.Product.Name,
                dgCount = _.ProductCount,
                dgPrice = _.ProductPrice,
                dgDiscount = _.ProductDiscount,
                dgDiscountPrice = (1 - _.ProductDiscount / 100) * _.ProductPrice,
                dgSum = (1 - _.ProductDiscount / 100) * _.ProductPrice * _.ProductCount
            }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var items = await Program._ShopDBContext.orderItems.Include(_ => _.Order).Where(_ => _.Order == null).ToListAsync();
            if(items.Count > 0)
            {
                await Program._ShopDBContext.orders.AddAsync(new Order() { Items = items, CreatedDate = DateTime.Now });
                await Program._ShopDBContext.SaveChangesAsync();
                MessageBox.Show("Վաճառքը կատարված է։");
                await updateGrid();
            }
        }

        private void ProductSaleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (productCount > 0 && productAveragePrice > 0)
            {
                decimal discountPrice = productDiscountPrice;
                ProductDiscountPriceTB.Text = productDiscountPrice
                    
                    .ToString();
                ProductSumeTextBox.Text= (discountPrice * productCount).ToString();
            }
        }
    }
}
