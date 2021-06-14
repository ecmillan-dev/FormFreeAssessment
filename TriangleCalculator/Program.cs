using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the triangle calculator.");
            while (true) 
            {
                Console.WriteLine("Please enter 3 triangle lengths (integer values) or anything else to quit the program.");
                // collect 3 valid side length inputs
                int[] sides = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Enter side #" + i + ": ");
                    var input = Console.ReadLine();
                    if (int.TryParse(input, out int result))
                    {
                        sides[i] = result;
                    }
                    else
                    {
                        Console.WriteLine("Input was not a valid integer so that will be assumed as an exit command. Good bye");
                        return; // completely bail from the program
                    }
                }

                var type = GetTriangleType(sides[0], sides[1], sides[2]);
                Console.WriteLine("The triangle type you inputed was " + type);                
            }

        }

        /// <summary>
        /// Determines the type of triangle based on the 3 input side lengths
        /// </summary>
        /// <param name="side1">first side length</param>
        /// <param name="side2">second side length</param>
        /// <param name="side3">third side length</param>
        /// <returns>Type of triangle (Scalene, Isosceles, Equilateral) or error</returns>
        public static string GetTriangleType(int side1, int side2, int side3)
        {
            // error checking for invalid triangle lengths
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                return "Invalid";
            }
            // begin logic to check equivalent sides, first has to be equilateral due to all 3 sides matching
            if (side1 == side2 && side1 == side3)
            {
                return "Equilateral";
            }
            // since first check is all 3 equal, we just need 1 equal check to pass (2 are equal)
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            // since no sides match we can return scalene
            else
            {
                return "Scalene";
            }
        }
    }
}
