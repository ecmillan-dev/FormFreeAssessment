using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.App
{
    /// <summary>
    /// Custom exception type for LinkedList for when the list contains less than 5 items
    /// </summary>
    public class TooFewItemsException : Exception
    {
        public TooFewItemsException(string message) : base(message)
        {
        }
       
    }
}
