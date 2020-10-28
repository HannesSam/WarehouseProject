using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class ProductNotInCatalogueException : Exception
    {
        public ProductNotInCatalogueException (string message) : base(message)
        {

        }
    }
}
