using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.App
{
    /// <summary>
    /// wrapper class for the linked list
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// the first node of the linked list
        /// </summary>
        public LinkedListNode Head { get; set; }

        #region helper values for searching for the list's 5th from the end element
        private int value1 { get; set; }
        private int value2 { get; set; }
        private int value3 { get; set; }
        private int value4 { get; set; }
        private int value5 { get; set; }
        #endregion

        /// <summary>
        /// constructor for an initial value
        /// </summary>
        /// <param name="startValue">head value</param>
        public LinkedList(int startValue)
        {
            Head = new LinkedListNode()
            {
                Next = null,
                Value = startValue,
            };
        }

        /// <summary>
        /// empty constructor
        /// </summary>
        public LinkedList()
        {

        }

        /// <summary>
        /// appends a value to the list
        /// </summary>
        ///  <param name="newValue">new value to add to the list</param>
        public void AddValue(int newValue)
        {
            if (Head == null)
            {
                Head = new LinkedListNode()
                {
                    Value = newValue,
                };
            }
            else
            {
                var currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = new LinkedListNode()
                {
                    Value = newValue,
                };
            }
            
        }

        /// <summary>
        /// Returns the 5th value from the end of the list
        /// </summary>
        /// <returns></returns>
        /// <throws>Exception if list is less than length of 5</throws>
        public int Get5thValueFromEnd()
        {
            var ListLength = 0;
            // throw an exception if the list is too short
            if (Head == null)
            {
                throw new TooFewItemsException("The list does not have enough elements to search for the 5th value from the end. List is empty");
            }

            // since we track the list length, we know what 5 back from the end is

            // start with the current node as the current node
            var currentNode = Head;
            ListLength++;
            // use the helper to "shuffle" values from the "back" of the list
            Get5thValueFromEndHelper(currentNode.Value);
            // keep going until we hit the end
            while (currentNode.Next != null)
            {
                // at the end we update our current node to the next node
                currentNode = currentNode.Next;
                // use the helper to "shuffle" values from the "back" of the list
                Get5thValueFromEndHelper(currentNode.Value);
                ListLength++;

            }
            // throw an error message if the list wasn't long enough
            if (ListLength < 5)
            {
                throw new TooFewItemsException("The list does not have enough elements to search for the 5th value from the end. List only contains " + ListLength + " elements");
            }

            // we know that if we make it here the value in value1 should be the 5th from the end of the list
            return value1;
        }

        /// <summary>
        /// a private helper to shuffle through the last 5 values
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private void Get5thValueFromEndHelper(int value)
        {
            value1 = value2;
            value2 = value3;
            value3 = value4;
            value4 = value5;
            value5 = value;
        }
    }
}
