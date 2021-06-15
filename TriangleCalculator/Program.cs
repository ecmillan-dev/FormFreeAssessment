using System;
using TriangleCalculator.App.Interface;
using TriangleCalculator.App.Service;

namespace TriangleCalculator.App
{
    public class TriangleCalculatorConsole
    {
        private static ITriangle _triangleService;
        static void Main(string[] args)
        {
            // init triangle service
            _triangleService = new TriangleService();
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

                var type = _triangleService.GetTriangleType(sides[0], sides[1], sides[2]);
                Console.WriteLine("The triangle type you inputed was " + type);                
            }

        }

        
    }
}
