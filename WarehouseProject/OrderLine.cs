using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class OrderLine
    {
        public Product Product { get; set; }
        public int Count { get; set; }

        public OrderLine(Product _product, int _count)
        {
            this.Product = _product;
            this.Count = _count;
        }
    }
}
