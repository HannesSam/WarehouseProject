using System;

namespace WarehouseProject
{
    class IntOrDoubleNegativeException : Exception
    {
        public IntOrDoubleNegativeException(string message) : base(message)
        {

        }
    }
}
