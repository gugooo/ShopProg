using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShopProg.Classes;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ShopProg
{
    public partial class CustomerAddOrChange : Form
    {
        public int? CustomerId = null;
        public event Action dataGridUpdateEvent;
        public CustomerAddOrChange()
        {
            InitializeComponent();
        }
        public CustomerAddOrChange(int CustomerId)
        {
            this.CustomerId = CustomerId;
            InitializeComponent();
            UpdateFormData();
        }
        private async void UpdateFormData()
        {
            if(CustomerId != null)
            {
                var customer = await Program._ShopDBContext.customers.FirstOrDefaultAsync(_ => _.Id == CustomerId);
                if(customer != null)
                {
                    this.CustomerCodeTextBox.Text = customer.Code;
                    this.CustomerNameTextBox.Text = customer.Name;
                    this.CustomerLNameTextBox.Text= customer.LName;
                    this.CustomerPhoneTextBox.Text = customer.Phone;
                    this.CustomerDiscountTextBox.Text=customer.Discount.ToString();
                }
            }
        }

        private async void CustomerAddOrChangeButton_Click(object sender, EventArgs e)
        {
            string code=this.CustomerCodeTextBox.Text;
            string name=this.CustomerNameTextBox.Text;
            string phone=this.CustomerPhoneTextBox.Text;
            string lName=this.CustomerLNameTextBox.Text;
            if (code.Length != 0 && name.Length != 0 && phone.Length != 0 && lName.Length != 0 && decimal.TryParse(this.CustomerDiscountTextBox.Text, out decimal discount) && discount > 0)
            {
                if (this.CustomerId != null)
                {
                    var customer = await Program._ShopDBContext.customers.FirstOrDefaultAsync(_ => _.Id == CustomerId);
                    if(customer != null)
                    {
                        customer.Code = code;
                        customer.Name = name;
                        customer.Phone = phone;
                        customer.Discount = discount;
                        customer.LName = lName;
                        Program._ShopDBContext.customers.Update(customer);
                        await Program._ShopDBContext.SaveChangesAsync();
                        MessageBox.Show("Տվյալները փոփոխված են։");
                    }    
                }
                else
                {
                    await Program._ShopDBContext.customers.AddAsync(new Customer() { Code = code, Discount = discount, Name = name, LName = lName, Phone = phone });
                    await Program._ShopDBContext.SaveChangesAsync();
                    MessageBox.Show("Նոր գնորդը ավելացվել է։");
                }
                dataGridUpdateEvent();
            }
        }

        private void CustomerCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
