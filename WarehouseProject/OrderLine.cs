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

        /// <summary>Konstruktor för OrderLine-objekt, som tar in vilken produkt och hur många av den som är beställd. Tar emot en produkt och antal</summary>
        public OrderLine(Product _product, int _count)
        {
            Product = product;
            Count = count;
        }

        /// <summary>Returnerar ett korrekt format på informationen i OrderLine </summary>
        public override string ToString()
        {
            return Product.Name + " Quantity : " + Count;
        }
    }
}
