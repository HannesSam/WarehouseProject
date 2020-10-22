using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    class DateNotInFutureException : Exception
    {
        public DateNotInFutureException (string message) : base(message)
        {

        }
    }
}
