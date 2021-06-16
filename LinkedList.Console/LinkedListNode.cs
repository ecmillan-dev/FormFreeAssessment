using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.App
{
    /// <summary>
    /// The int value node of the linked list
    /// </summary>
    public class LinkedListNode<TSource>
    {
        /// <summary>
        /// Points to the next node of the list
        /// </summary>
        public LinkedListNode<TSource> Next { get; set; }
        /// <summary>
        /// Holds the integer value of the node
        /// </summary>
        public TSource Value { get; set; }
    }
}
