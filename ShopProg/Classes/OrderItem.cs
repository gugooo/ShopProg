using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProg.Classes
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        public Customer Customer { get; set; }
    }
}
