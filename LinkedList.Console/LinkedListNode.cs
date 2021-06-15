using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.App
{
    /// <summary>
    /// The int value node of the linked list
    /// </summary>
    public class LinkedListNode
    {
        /// <summary>
        /// Points to the next node of the list
        /// </summary>
        public LinkedListNode Next { get; set; }
        /// <summary>
        /// Holds the integer value of the node
        /// </summary>
        public int Value { get; set; }
    }
}
