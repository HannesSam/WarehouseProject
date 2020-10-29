using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass enda funktion är att kunna urskilja olika exception och denna används till
    /// exceptions där en int eller double är negativ.
    /// </summary>
    class IntOrDoubleNegativeException : Exception
    {
        public IntOrDoubleNegativeException(string message) : base(message)
        {

        }
    }
}
