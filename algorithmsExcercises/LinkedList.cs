using System;

namespace algorithmsExercises
{
    class Node
    {
        public object data;
        public Node next;

        public Node()
        {
            data = null;
            next = null;
        }

        public Node(Object n, Node m)
        {
            data = n;
            next = m;
        }
    }

    class LinkedList
    {
        private int size;
        private Node _head;
        private Node _tail;

        // Constructs default list
        public LinkedList()
        {
            size = 0;
            _head = null;
            _tail = null; 
        }

        // Keeps count of list
        public int Count
        {
            get
            {
                return size;
            }
        }

        // Add object to the front
        public void AddToFront(object item)
        {
            size++;
            var insert = new Node(item, null);
            if (_head == null)
            {
                _head = _tail = insert;
                Console.WriteLine("Set item to head and tail");
            }
            else
            {
                insert.next = _head;
                _head = insert;
            }
        }

        //Add object to the back
        public void AddToBack(object item)
        {
            size++;
            var insert = new Node(item, null);
            if (_head == null)
            {
                _head = _tail = insert;
                Console.WriteLine("Set item to head and tail");
            }
            else
            {
                _tail.next = insert;
                _tail = insert;
                Console.WriteLine("Set item to just tail");
            }
        }

        //Delete and retrieve item from front
        public object DeleteFromFront()
        {
            Node item = new Node();
            item = _head;
            if (_head == null)
            {
                return null;
            }
            else
            {
                _head.next = _head;
                return item;
            }
        }

        public String ToString()
        {
            String completeList = "";

            Node tempNode = _head;

            while (tempNode != null)
            {
                completeList += tempNode.data + "\n";
                tempNode = tempNode.next;
            }

            return completeList;
        }
    }
}
