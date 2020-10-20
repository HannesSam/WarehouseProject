using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public DateTime FirstAvailable { get; set; }
        public DateTime NextStocking { get; set; }

        public Product(int _code, string _name, double _price, int _stock, DateTime _firstAvailable, DateTime _nextStocking)
        {
            this.Code = _code;
            this.Name = _name;
            this.Price = _price;
            this.Stock = _stock;
            this.FirstAvailable = _firstAvailable;
            this.NextStocking = _nextStocking;
        }


    }
}
