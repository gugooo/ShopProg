using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProg.Classes
{
    internal class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public List<SupplierProductListItem> ProductListItems { get; set; }

    }
}
