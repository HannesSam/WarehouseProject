using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass enda funktion är att kunna urskilja olika exception och denna används till
    /// exceptions där produkten inte finns i produktkatalogen.
    /// </summary>
    class ProductNotInCatalogueException : Exception
    {
        public ProductNotInCatalogueException (string message) : base(message)
        {

        }
    }
}
