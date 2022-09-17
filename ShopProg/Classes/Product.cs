using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProg.Classes
{
    internal class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ProductGroupID { get; set; }
        public ProductGrup ProductGrup { get; set; }
    }
}
