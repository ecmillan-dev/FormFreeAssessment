using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleCalculator.App.Interface
{
    public interface ITriangle
    {
        /// <summary>
        /// Determines the type of triangle based on the 3 input side lengths
        /// </summary>
        /// <param name="side1">first side length</param>
        /// <param name="side2">second side length</param>
        /// <param name="side3">third side length</param>
        /// <returns>Type of triangle (Scalene, Isosceles, Equilateral) or error</returns>
        string GetTriangleType(int side1, int side2, int side3);
    }        
}
