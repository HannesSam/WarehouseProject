using System;

namespace WarehouseProject
{
    class ProductNotInCatalogueException : Exception
    {
        public ProductNotInCatalogueException(string message) : base(message)
        {

        }
    }
}
