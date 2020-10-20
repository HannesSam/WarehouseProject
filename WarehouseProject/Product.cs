using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class Product
    {
        int Code { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        int Stock { get; set; }
        DateTime FirstAvailable { get; set; }
        DateTime NextStocking { get; set; }

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
