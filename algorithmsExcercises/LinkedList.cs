using System;

namespace algorithmsExercises
{
    class Node
    {
        public object data;
        public Node next;
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

        // Add item to list to the front
        public void AddToFront(object item)
        {
            size++;

            var insert = new Node();

            insert.data = item;
            insert.next = _head;
            _head = insert;
        }

        //Add item to the back
        public void AddToBack(object item)
        {
            size++;

            var insert = new Node();
            Node pointer = new Node();

            pointer = _head;
            insert.data = item;
            insert.next = _tail;

            if (_head == null)
            {
                _head = insert;
                _head.next = _tail;
                return;
            }

            while (pointer.next != null)
            {
                pointer = pointer.next;
            }

            pointer.next = insert;
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
