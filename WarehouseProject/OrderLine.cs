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
            Product = product;
            Count = count;
        }

        public override string ToString()
        {
            return Product.Name + " Quantity : " + Count;
        }
    }
}
