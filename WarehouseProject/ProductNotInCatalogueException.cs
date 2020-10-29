using System;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass enda funktion är att kunna urskilja olika exception och denna används till
    /// exceptions där en produkt inte finns i produktkatalogen.
    /// </summary>
    class ProductNotInCatalogueException : Exception
    {
        public ProductNotInCatalogueException(string message) : base(message)
        {

        }
    }
}
