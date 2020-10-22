using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class IntOrDoubleWrongFormatException : Exception
    {
        public IntOrDoubleWrongFormatException(string message) : base(message)
        {

        }
}
}
