using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.LinkedLists
{
    public class SinglyLinkedList<T>
    {
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }

        public int Count { get; private set; }
        public bool IsEmpty { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        private void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            Head = node;
            //Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head; 
            }
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        private void AddLast(LinkedListNode<T> node)
        {
            if (IsEmpty)
            {

            }
        }
    }
}
