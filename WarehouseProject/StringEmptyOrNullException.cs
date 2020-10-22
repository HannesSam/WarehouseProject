using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    public class StringEmptyOrNullException : Exception
    {
        public StringEmptyOrNullException(string message) : base(message)
        {

        }
    }
}
