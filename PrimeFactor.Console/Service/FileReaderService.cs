using PrimeFactor.App.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PrimeFactor.App.Service
{
    public class FileReaderService : IFileReader
    {
        /// <summary>
        /// Gets a list of integers to calculate prime factors of from an input file
        /// </summary>
        /// <param name="fileName">the full file path for the input file</param>
        /// <returns></returns>
        public IEnumerable<int> GetIntegerLinesFromInputFile(string fileName)
        {
            // first try to locate the file
            string[] inputLines;
            try
            {
                inputLines = File.ReadAllLines(fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("Invalid file path specified - " + fileName);
                throw;
            }

            // now that we have the file lines, iterate through each one to parse out an int value from the line
            // anything not expected in one of those lines will throw an exception
            List<int> values = new List<int>();
            for (int i = 0; i < inputLines.Length; i++)
            {
                // use try parse and make sure the value is more than 1
                if (int.TryParse(inputLines[i], out int value) && value > 1)
                {
                    values.Add(value);
                }
                else
                {
                    throw new InvalidIntegerInputException("The file contained the following invalid integer input on line #" + (i + 1) + " - " + inputLines[i]);
                }
            }
            return values;
        }

    }
}
