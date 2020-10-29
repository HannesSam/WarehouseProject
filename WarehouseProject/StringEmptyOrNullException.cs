using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseProject
{    /// <summary>
     /// Denna klass enda funktion är att kunna urskilja olika exception och denna används till
     /// exceptions där en sträng är tom eller null.
     /// </summary>
    public class StringEmptyOrNullException : Exception
    {
        public StringEmptyOrNullException(string message) : base(message)
        {

        }
    }
}
