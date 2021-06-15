using PrimeFactor.App.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactor.App.Service
{
    public class PrimeFactorService : IPrimeFactor
    {
        /// <summary>
        /// Returns the list of prime factors for an integer
        /// </summary>
        /// <param name="value">integer value</param>
        /// <returns>a string list (comma delimited) of the input's prime factors</returns>
        public string GetPrimeFactorList(int value)
        {
            var factorList = "";
            
            // first process all factors of 2
            while (value % 2 == 0)
            {
                factorList += ",2";
                value /= 2;
            }

            // we only have to go up to the square root of the value
            // we can iterate by every odd number starting at 3
            // even though this will have non-prime values of factor, it will never add them to the list
            for (int factor = 3; factor <= Math.Sqrt(value); factor += 2)
            {
                while (value % factor == 0)
                {
                    factorList += "," + factor;
                    value /= factor;
                }
            }
            // add the last factor
            if (value > 2)
                factorList += "," + value;

            // cut out the first comma
            return factorList[1..];
        }

       
    }
}
