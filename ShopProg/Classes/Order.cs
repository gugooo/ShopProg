using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProg.Classes
{
    internal class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
