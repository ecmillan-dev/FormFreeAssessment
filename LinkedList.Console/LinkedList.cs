using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
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
        private int searchValue1 { get; set; }
        private int searchValue2 { get; set; }
        private int searchValue3 { get; set; }
        private int searchValue4 { get; set; }
        private int searchValue5 { get; set; }
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
            var currentNode = Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
        }

        /// <summary>
        /// Returns the 5th value from the end of the list
        /// </summary>
        /// <returns></returns>
        /// <throws>Exception if </throws>
        public int Get5thValueFromEnd()
        {
            // start with the current node as the current node
            var currentNode = Head;
            int listLength = 0;
            // keep going until we hit the end
            while (currentNode.Next != null)
            {
                // update how long this list is 
                listLength++;
                // at the end we update our current node to the next node
                currentNode = currentNode.Next;
            }

            if (listLength < 5)
            {
                throw new Exception("The list does not have enough elements to search for the 5th value from the end. List only contains " + listLength + " elements");
            }

            //
            return 5;
        }
    }
}
