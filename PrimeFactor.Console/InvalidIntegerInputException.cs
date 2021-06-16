using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactor.App
{
    /// <summary>
    /// Custom exception for when the input line in the file isn't a valid integer to prime factorize
    /// </summary>
    public class InvalidIntegerInputException : Exception
    {
        public InvalidIntegerInputException(string message) : base(message)
        {

        }
    }
}
