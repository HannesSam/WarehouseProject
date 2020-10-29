using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{
    /// <summary>
    /// Denna klass enda funktion är att kunna urskilja olika exception och denna används till
    /// exceptions där en int eller double är i fel format. 
    /// </summary>
    class IntOrDoubleWrongFormatException : Exception
    {
        public IntOrDoubleWrongFormatException(string message) : base(message)
        {

        }
}
}
