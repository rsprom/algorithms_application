using System;

namespace algorithmsExcercises
{
    class LinkedList
    {
        public class Node
        {
            public object node;
            public Node next;
        }

        private int size;

        public int Count
        {
            get
            {
                return size;
            }
        }

        private Node head;
        private Node current;

        // Constructs default list
        public LinkedList()
        {
            size = 0;
            head = null;
        }

        // Add item to list
        public void Add(object item)
        {
            size++;

            var node = new Node()
            {
                node = item
            };

            if (head == null)
                head = node;
            else
                current.next = node;

            Console.WriteLine("Written Object");
        }

        // Delete specific item from the list
        public void Delete(object item)
        {
            size--;

            Node pointer = current;

            if (pointer.Equals(item))
            {
                current = current.next;
            }
            else
            {
                pointer = current.next;
            }

            Console.WriteLine("Deleted Object");

        }

    }
}
