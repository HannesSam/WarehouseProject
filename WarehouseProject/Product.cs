using System;

namespace WarehouseProject
{
    /// <summary>
    /// Klass som innehåller all information och funktionalitet som behövs för en produkt.
    /// </summary>
    public class Product
    {
        private int _code;
        private string _name;
        private double _price;
        private int _stock;
        private DateTime _firstAvailable;
        private DateTime _nextStocking;

        /// <value>En produkts unika kod, för att kunna skilja på de olika produkterna.</value>
        public int Code
        {
            get { return _code; }
            set
            {
                if (value < 0)
                    throw new IntOrDoubleNegativeException("Code cannot be negative.");
                else
                {
                    _code = value;
                }
            }
        }

        /// <value>Name är produktens namn, som visas i gränssnittet.</value>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringEmptyOrNullException("Name cannot be null or empty.");
                }
                else
                {
                    _name = value;
                }
            }
        }
        /// <value>Price är det pris som sätts på produkten</value>
        public double Price
        {
            get { return _price; }
            set { if (value < 0) throw new IntOrDoubleNegativeException("Price cannot be negative."); else _price = value; }
        }

        /// <value>Stock är det antal av produkten som läggs in när den skapas eller uppdateras</value>
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
        /// <value>FirstAvailable är det datum som ett angivet antal av en produkt finns tillgängliga för dispatch</value>
        public DateTime FirstAvailable
        {
            get { return _firstAvailable; }
            set { if (value < DateTime.Now) throw new DateNotInFutureException("Date must be in the future"); else _firstAvailable = value; }
        }

        /// <value>NextStocking är det datum som ett antal av en produkt fylls på och finns tillgängliga för dispatch</value>
        public DateTime NextStocking
        {
            get { return _nextStocking; }
            set { if (value < DateTime.Now) throw new DateNotInFutureException("Date must be in the future"); else _nextStocking = value; }
        }

        /// <summary>En tom konstruktor för att JSON Deserilazation ska fungera.<</summary>
        public Product()
        {

        }
        /// <summary>
        /// Konstruktor för att skapa ett Product-objekt
        /// </summary>
        /// <param name="_code">Heltal</param>
        /// <param name="_name">Sträng</param>
        /// <param name="_price">Double</param>
        /// <param name="_stock">Heltal</param>
        /// <param name="_firstAvailable">DateTime</param>
        /// <param name="_nextStocking">DateTime</param>
        public Product(int _code, string _name, double _price, int _stock, DateTime _firstAvailable, DateTime _nextStocking)
        {
            this.Code = _code;
            this.Name = _name;
            this.Price = _price;
            this.Stock = _stock;
            this.FirstAvailable = _firstAvailable;
            this.NextStocking = _nextStocking;
        }

        /// <summary>
        /// Returnerar korrekt formaterad info om en produkt
        /// </summary>
        /// <returns>Sträng</returns>
        public override string ToString()
        {
            return Name + " Price: " + Price + " Stock : " + Stock;
        }

    }
}
