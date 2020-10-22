using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class Product
    {
        private int _code;
        private string _name;
        private double _price;
        private int _stock;
        private DateTime _firstAvailable;
        private DateTime _nextStocking;
        public Product()
        {

        }
        public int Code
        {
            get { return _code; }
            set 
            { if (value < 0)
                    throw new Exception("Code cannot be negative.");
              else
              {
                    _code = value;
              }
            }
        }
        public string Name
        {
            get { return _name; }
            set 
            {   if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be null or empty.");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public double Price
        {
            get { return _price; }
            set { if (value < 0) throw new Exception("Price cannot be negative."); else _price = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 0)
                    throw new Exception("Stock cannot be negative.");
                else
                {
                    _stock = value;
                }
            }
        }
        public DateTime FirstAvailable
        {
            get { return _firstAvailable; }
            set { if (value < DateTime.Now) throw new Exception("Date must be in the future"); else _firstAvailable = value; }
        }
        public DateTime NextStocking
        {
            get { return _nextStocking; }
            set { if (value < DateTime.Now) throw new Exception("Date must be in the future"); else _nextStocking = value; }
        }
        public Product(int _code, string _name, double _price, int _stock, DateTime _firstAvailable, DateTime _nextStocking)
        {
            this.Code = _code;
            this.Name = _name;
            this.Price = _price;
            this.Stock = _stock;
            this.FirstAvailable = _firstAvailable;
            this.NextStocking = _nextStocking;
        }

        public override string ToString()
        {
            return Name + " Price: " + Price + " Stock : " + Stock;
        }

    }
}
