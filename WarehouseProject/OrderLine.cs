﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class OrderLine
    {
        private int _count;
        private Product _product;
        public Product Product { get { return _product; } set { _product = value; } }
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 0)
                    throw new IntOrDoubleNegativeException("Quantity cannot be negative.");
                else
                {
                    _count = value;
                }
            }
        }

        public OrderLine()
        {

        }
        public OrderLine(Product product, int count)
        {
            _product = product;
            _count = count;
        }

        public override string ToString()
        {
            return Product.Name + " Quantity : " + Count;
        }
    }
}
