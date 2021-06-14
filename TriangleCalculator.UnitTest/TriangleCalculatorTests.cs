using NUnit.Framework;
using TriangleCalculator;

namespace TriangleCalculator
{
    public class TriangleCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        /// <summary>
        /// Unit tests to verify that the program returns equilateral (or invalid) when it is supposed to
        /// </summary>
        [Test]
        public void TestEquilaterial()
        {
            var type = "Equilateral";
            var calculator = new TriangleCalculatorConsole();
            // a few different values as expected
            Assert.AreEqual(type, calculator.GetTriangleType(1, 1, 1));
            Assert.AreEqual(type, calculator.GetTriangleType(5, 5, 5));
            Assert.AreNotEqual(type, calculator.GetTriangleType(1, 1, 5));
            Assert.AreNotEqual(type, calculator.GetTriangleType(3, 4, 5));
            Assert.AreNotEqual(type, calculator.GetTriangleType(3, 4, 0));
            Assert.AreNotEqual(type, calculator.GetTriangleType(3, 4, -1));
        }

        /// <summary>
        /// Unit tests to verify that the program returns Isosceles (or invalid) when it is supposed to
        /// </summary>
        [Test]
        public void TestIsosceles()
        {
            var type = "Isosceles";
            var calculator = new TriangleCalculatorConsole();
            // a few different values as expected
            Assert.AreEqual(type, calculator.GetTriangleType(1, 1, 2));
            Assert.AreEqual(type, calculator.GetTriangleType(5, 3, 5));
            Assert.AreEqual(type, calculator.GetTriangleType(4, 7, 7));
            Assert.AreNotEqual(type, calculator.GetTriangleType(6, 1, 5));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 4, 4));
            Assert.AreNotEqual(type, calculator.GetTriangleType(3, 4, 0));
            Assert.AreNotEqual(type, calculator.GetTriangleType(3, 4, -1));
        }

        /// <summary>
        /// Unit tests to verify that the program returns Scalene (or invalid) when it is supposed to
        /// </summary>
        [Test]
        public void TestScalene()
        {
            var type = "Scalene";
            var calculator = new TriangleCalculatorConsole();
            Assert.AreEqual(type, calculator.GetTriangleType(1, 3, 2));
            Assert.AreEqual(type, calculator.GetTriangleType(5, 3, 4));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 4, 4));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 4, 3));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 3, 4));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 4, 4));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 3, 3));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 4, 4));
            Assert.AreNotEqual(type, calculator.GetTriangleType(3, 4, 0));
            Assert.AreNotEqual(type, calculator.GetTriangleType(3, 4, -1));
        }

        [Test]
        public void TestInvalid()
        {
            var type = "Invalid";
            var calculator = new TriangleCalculatorConsole();
            Assert.AreEqual(type, calculator.GetTriangleType(0, 3, 2));
            Assert.AreEqual(type, calculator.GetTriangleType(0, 0, 0));
            Assert.AreEqual(type, calculator.GetTriangleType(0, 0, -1));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 3, 4));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 4, 4));
            Assert.AreNotEqual(type, calculator.GetTriangleType(4, 3, 5));
        }
    }
}