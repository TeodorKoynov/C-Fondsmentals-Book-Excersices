using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter16Excersices
{
    class DynamicStack<T>
    {
        // Fields
        private Node top;
        private int count;

        // Properties
        public int Count
        {
            get { return this.count; }
        }

        // Internal Class
        private class Node
        {
            // Fields
            private Node next;
            private T element;

            // Properties
            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
            public T Element
            {
                get { return this.element; }
                set { this.element = value; }
            }

            // Constructor
            public Node(T element)
            {
                this.element = element;
                this.next = null;
            }
        }

        // Constructor
        public DynamicStack()
        {
            top = null;
        }

        // Methods

        public void Push(T element)
        {
            if (top == null)
            {
                top = new Node(element);
                count++;
            }
            else
            {
                Node newNode = new Node(element);
                newNode.Next = top;
                top = newNode;
                count++;
            }
        }
        public T Pop()
        {
            T element = this.top.Element;
            this.top = top.Next;
            count--;
            return element;
        }
        public T Peek()
        {
            return this.top.Element;
        }
        public void Clear()
        {
            while (this.top != null)
            {
                this.top = this.top.Next;
            }
            count = 0;
        }
        public bool Contains(T element)
        {
            bool contains = false;
            Node search = top;
            while (search != null)
            {
                if (search.Element.Equals(element))
                {
                    contains = true;
                    return contains;
                }
                search = search.Next;
            }
            return contains;
        }

        public T[] ToArray()
        {
            int index = 0;
            T[] array = new T[this.count];
            while (top != null)
            {
                array[index] = top.Element;
                index++;
                top = top.Next;
            }
            return array;
        }

    }
}
