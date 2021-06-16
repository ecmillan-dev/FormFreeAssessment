using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactor.App.Interface
{
    /// <summary>
    /// Interface to handle reading in the input files for prime factoring
    /// </summary>
    public interface IFileReader
    {
        /// <summary>
        /// Gets a list of integers to calculate prime factors of from an input file
        /// </summary>
        /// <param name="fileName">the full file path for the input file</param>
        /// <returns></returns>
        IEnumerable<int> GetIntegerLinesFromInputFile(string fileName);
    }
}
