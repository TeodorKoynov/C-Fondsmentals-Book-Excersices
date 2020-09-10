using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter16Excersices
{
    public class DoubleLinedList<T>
    {
        // Fields
        private int count = 0;
        private Node head = null;
        private Node tail = null;

        // Properties
        public int Count
        {
            get
            {
                return this.count;
            }
        }


        private class Node
        {
            private T value = default;
            private Node nextNode;
            private Node prevNode;

            public T Value
            {
                get { return this.value; }
                set { this.value = value; }
            }
            public Node NextNode
            {
                get { return this.nextNode; }
                set { this.nextNode = value; }
            }
            public Node PrevNode
            {
                get { return this.prevNode; }
                set { this.prevNode = value; }
            }

            public Node(T value, Node nextNode, Node prevNode)
            {
                this.value = value;
                this.nextNode = nextNode;
                this.prevNode.NextNode = this;
            }
            public Node(T value, Node prevNode)
            {
                this.value = value;
                this.prevNode = prevNode;
            }
            public Node(T value)
            {
                this.value = value;
                this.nextNode = null;
                this.prevNode = null;
            }
        }

        // Constructors
        public DoubleLinedList()
        {
            this.head = null;
            this.tail = null;
        }
        
        // Methods
        public void Add(T element)
        {
            if (head == null && tail == null)
            {
                head = new Node(element);
                head.PrevNode = null;
                this.tail = this.head;
                head.NextNode = tail;
                tail.PrevNode = head;
                head.PrevNode = null;
                tail.NextNode = null;
            }
            else
            {
                Node nextNode = new Node(element, this.tail);
                this.tail = nextNode;
                nextNode.PrevNode.NextNode = nextNode;
            }
            count++;
        }

    }
}
