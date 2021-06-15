using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactor.App.Interface
{
    /// <summary>
    /// Interface for calculating prime factors of an integer
    /// </summary>
    public interface IPrimeFactor
    {
        /// <summary>
        /// Returns the list of prime factors for an integer
        /// </summary>
        /// <param name="value">integer value</param>
        /// <returns>a string list (comma delimited) of the input's prime factors</returns>
        string GetPrimeFactorList(int value);
    }
}
