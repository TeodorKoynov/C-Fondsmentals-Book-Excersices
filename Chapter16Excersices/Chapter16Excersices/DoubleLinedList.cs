using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter16Excersices
{
    public class DoubleLinedList<T>
        where T : IComparable<T>
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
        public void Remove(T element)
        {
            if (head.Value.Equals(element)) // If element is head
            {
                head = head.NextNode;
                head.PrevNode = null;
                count--;
             //  return;
            }
            if (tail.Value.Equals(element)) // If element is tail
            {
                tail = tail.PrevNode;
                tail.NextNode = null;
                count--;
              //  return;
            }
          //  int index = 0;
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(element))
                {
                    currentNode.PrevNode.NextNode = currentNode.NextNode;
                    currentNode.NextNode.PrevNode = currentNode.PrevNode;
                    currentNode = currentNode.NextNode;
                    count--;
                }
                currentNode = currentNode.NextNode;
                //index++;
            }
            
        }
        public bool Contains(T element)
        {
            bool contains = false;
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(element))
                {
                    contains = true;
                    return contains;
                }
                currentNode = currentNode.NextNode;
            }
            return contains;
        }
        public void InsertAt(T element, int index)
        {
            Node newNode = new Node(element);
            Node currentNode = head;
            int currentIndex = 0;
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
            if (index == 0)
            {
                Node swap = head;
                swap.PrevNode = newNode;
                newNode.PrevNode = null;
                newNode.NextNode = swap;
                head = newNode;
                count++;
                return;
            }
            if (index == count - 1)
            {
                newNode.NextNode = tail;
                newNode.PrevNode = tail.PrevNode;
                tail.PrevNode.NextNode = newNode;
                tail.PrevNode = newNode;
                count++;
                return;
            }
            while (currentIndex != index || currentIndex == index)
            {
                if (currentIndex == index)
                {
                    newNode.NextNode = currentNode;
                    newNode.PrevNode = currentNode.PrevNode;
                    currentNode.PrevNode.NextNode = newNode;
                    currentNode.PrevNode = newNode;
                    count++;
                    break;
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
        }
        public T this[int index]
        {

            get
            {
                int currentIndex = 0;
                Node currentNode = head;
                while (currentNode != null)
                {
                    if (index == currentIndex)
                    {
                        break;
                    }
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }
                return currentNode.Value;
            }
            set
            {
                int currentIndex = 0;
                Node currentNode = head;
                while (currentNode != null)
                {
                    if (index == currentIndex)
                    {
                        break;
                    }
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }
                currentNode.Value = value;
            }
        }
        public static T[] ToArray(DoubleLinedList<T> list)
        {
            T[] array = new T[list.count];
            if (list.count == 0)
            {
                return array;
            }
            int index = 0;
            Node currentNode = list.head;
            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                currentNode = currentNode.NextNode;
                index++;
            }
            return array;
        }

        public void Sort()
        {   
           for (int i = 0; i < count - 1; i++)
           {
                for (int j = i + 1; j < count; j++)
                {
                    if (Compare(this[i], this[j]))
                    {
                        T swap = this[i];
                        this[i] = this[j];
                        this[j] = swap;
                    }

                }
           }
        }
        
        /// <summary>
        /// Returns true if first is greater
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private static bool Compare(T first, T second)
        {
            return first.CompareTo(second) > 0;
        }
    }
}
