using System;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass enda funktion är att kunna urskilja olika exception och denna används till
    /// exceptions där en DateTime är ett datum som  har passerat.
    /// </summary>
    class DateNotInFutureException : Exception
    {
        public DateNotInFutureException(string message) : base(message)
        {

        }
    }
}
