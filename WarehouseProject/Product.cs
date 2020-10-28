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
                    throw new IntOrDoubleNegativeException("Code cannot be negative.");
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
                    throw new StringEmptyOrNullException("Name cannot be null or empty.");
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
            set { if (value < 0) throw new IntOrDoubleNegativeException("Price cannot be negative."); else _price = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 0)
                    throw new IntOrDoubleNegativeException("Stock cannot be negative.");
                else
                {
                    _stock = value;
                }
            }
        }
        public DateTime FirstAvailable
        {
            get { return _firstAvailable; }
            set { if (value < DateTime.Now) throw new DateNotInFutureException("Date must be in the future"); else _firstAvailable = value; }
        }
        public DateTime NextStocking
        {
            get { return _nextStocking; }
            set { if (value < DateTime.Now) throw new DateNotInFutureException("Date must be in the future"); else _nextStocking = value; }
        }
        public Product(int code, string name, double price, int stock, DateTime firstAvailable, DateTime nextStocking)
        {
            Code = code;
            Name = name;
            Price = price;
            Stock = stock;
            FirstAvailable = firstAvailable;
            NextStocking = nextStocking;
        }

        public override string ToString()
        {
            return Name + " Price: " + Price + " Stock : " + Stock;
        }

    }
}
