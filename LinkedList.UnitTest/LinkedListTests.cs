using NUnit.Framework;
using LinkedList.App;

namespace LinkedList.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// testing the linked list class with a simple 10 item list generated by a for loop
        /// </summary>
        [Test]
        public void Test10ItemsSimple()
        {
            var list = new LinkedList<int>();
            // first one will be 10 values in the list
            for (int i = 1; i <= 10; i++)
            {
                list.AddValue(i);
            }
            // we know the 5th value from the back is 6
            Assert.AreEqual(6, list.Get5thValueFromEnd());
            Assert.AreNotEqual(5, list.Get5thValueFromEnd());

            // test out a string list
            var list2 = new LinkedList<string>();
            for (int i = 1; i <= 10; i++)
            {
                list2.AddValue("string " + i);
            }

            Assert.AreEqual("string 6", list2.Get5thValueFromEnd());
            Assert.AreNotEqual("string 5", list2.Get5thValueFromEnd());
        }

        /// <summary>
        /// Tests that the LinkedList class throws an exception if there are less than 5 elements, the minimum to perform the task
        /// </summary>
        [Test]
        public void Test3ItemsException()
        {
            var list = new App.LinkedList<int>();
            list.AddValue(5);
            list.AddValue(7);

            // test that correct exception type is thrown
            Assert.Catch<TooFewItemsException>(delegate { list.Get5thValueFromEnd(); });
            
            var ex = Assert.Throws<TooFewItemsException>(
                delegate { list.Get5thValueFromEnd(); });

            Assert.AreEqual(ex.Message, "The list does not have enough elements to search for the 5th value from the end. List only contains 2 elements");

        }

        [Test]
        public void Test5ManualItems()
        {
            var list = new App.LinkedList<int>();
            list.AddValue(3);
            list.AddValue(1);
            list.AddValue(78);
            list.AddValue(0);
            list.AddValue(5);
            Assert.AreEqual(3, list.Get5thValueFromEnd());
        }
    }
}