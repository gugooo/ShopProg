using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ShopProg.Classes;

namespace ShopProg
{
    public partial class ProductAddOrChange : Form
    {
        public int? ProductIsChange = null;
        public event Action UpdateDataGrid;
        public ProductAddOrChange()
        {
            InitializeComponent();
            formInit();
        } 
        
        void formInit()
        {
            var grups = Program._ShopDBContext.grups.ToList();
            if(grups.Count > 0)
            {
                var items = grups.Select(_ => new ComboboxItem() { Text = _.Name, Value = _.Id });
                foreach(var item in items)
                {
                    this.ProductGroupComboBox.Items.Add(item);
                }
                if (items.Count() > 0) this.ProductGroupComboBox.SelectedIndex = 0;
            }

            
        }

        private async void ProductAddOrChangeButton_Click(object sender, EventArgs e)
        {
            var code=this.ProductCodeTextBox.Text;
            var name=this.ProductNameTextBox.Text;
            int? groupId = (this.ProductGroupComboBox.SelectedItem as ComboboxItem).Value;
            if(code.Length>0 && name.Length>0 && groupId != null)
            {
                if (ProductIsChange == null)
                {
                    var group = await Program._ShopDBContext.grups.FirstOrDefaultAsync(_ => _.Id == groupId);
                    if (group != null)
                    {
                        await Program._ShopDBContext.products.AddAsync(new Classes.Product() { Code = code, Name = name, ProductGrup = group });
                        await Program._ShopDBContext.SaveChangesAsync();
                        MessageBox.Show("Ապրանքը ավելացված է։");
                        UpdateDataGrid();
                    }
                }
                else
                {
                    var product = await Program._ShopDBContext.products.Include(_=>_.ProductGrup).FirstOrDefaultAsync(_ => _.Id == ProductIsChange);
                    if (product != null)
                    {
                        if (groupId != product.ProductGrup.Id)
                        {
                            var group = await Program._ShopDBContext.grups.FirstOrDefaultAsync(_ => _.Id == groupId);
                            if (group != null) product.ProductGrup = group;
                        }
                        product.Code = code;
                        product.Name = name;
                        Program._ShopDBContext.products.Update(product);
                        await Program._ShopDBContext.SaveChangesAsync(); ;
                        MessageBox.Show("Ապրանքը Փոփոխված է։");
                        UpdateDataGrid();
                    }
                }
            }
        }

        private void ProductAddOrChangeCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAddOrChange_Shown(object sender, EventArgs e)
        {
            if (ProductIsChange != null)
            {
                var prod = Program._ShopDBContext.products.Include(_ => _.ProductGrup).FirstOrDefault(_ => _.Id == ProductIsChange);
                if (prod != null)
                {
                    ProductCodeTextBox.Text = prod.Code;
                    ProductNameTextBox.Text = prod.Name;
                    ProductGroupComboBox.Text = prod.ProductGrup.Name;
                }
            }
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
