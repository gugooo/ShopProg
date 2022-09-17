using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProg.Classes
{
    internal class SupplierProductListItem
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductProfit { get; set; }
        public DateTime ProductValidDate { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
