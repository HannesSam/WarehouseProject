using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class IntOrDoubleNegativeException : Exception
    {
        public IntOrDoubleNegativeException(string message) : base(message)
        {

        }
    }
}
