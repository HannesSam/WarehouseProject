using System;

namespace WarehouseProject
{
    class IntOrDoubleWrongFormatException : Exception
    {
        public IntOrDoubleWrongFormatException(string message) : base(message)
        {

        }
    }
}
