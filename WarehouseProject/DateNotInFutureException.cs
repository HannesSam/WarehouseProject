using System;

namespace WarehouseProject
{
    class DateNotInFutureException : Exception
    {
        public DateNotInFutureException(string message) : base(message)
        {

        }
    }
}
