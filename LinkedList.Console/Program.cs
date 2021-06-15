using System;

namespace LinkedList.App
{
    public class LinkedListConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the linked list searcher. This program will traverse a linked list to find the 5th value from the end of the list");
            Console.WriteLine("We will seed various linked lists with different lengths to demonstrate functionality");

            var list = new LinkedList();
            // first one will be 10 values in the list
            for (int i = 1; i <= 10; i++)
            {
                list.AddValue(i);
            }
            // expected value is 6
            Console.WriteLine("5th value from the end is " + list.Get5thValueFromEnd());

        }

        
    }
}

