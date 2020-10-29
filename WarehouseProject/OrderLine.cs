using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    /// <summary>
    /// Klass för enskilda produktbeställningar (produkt och antal) i varje order 
    /// </summary>
    public class OrderLine
    {
        private int _count;
        private Product _product;

        /// <value>Vilken produkt som beställs</value>
        public Product Product { get { return _product; } set { _product = value; } }
        
        /// <value>Det antal som beställs</value>
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

        /// <summary>Tom konstruktor för att JSON Deserialization ska fungera.</summary>
        public OrderLine()
        {

        }

        /// <summary>
        /// Konstruktor för OrderLine-objekt, som tar in vilken produkt och hur många av den som är beställd
        /// </summary>
        /// <param name="_product">Product-objekt</param>
        /// <param name="_count">Heltal</param>
        public OrderLine(Product _product, int _count)
        {
            this.Product = _product;
            this.Count = _count;
        }

        /// <summary>
        /// Returnerar ett korrekt format på informationen i OrderLine 
        /// </summary>
        public override string ToString()
        {
            return Product.Name + " Quantity : " + Count;
        }
    }
}
