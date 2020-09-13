using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter16Excersices
{
    class QueueWithArray<T>
    {
        // Fields
        private T[] elements = null;
        private int count = 0;
        private int capasity = 2;
        private int head = 0;
        private int tail = 0;
        private int index = 0;

        // Properties
        public int Count
        { 
            get { return count; }
        }
        public int Capasity
        {
            get 
            {
                if (count == 0)
                {
                    return 0;
                }
                else
                {
                    return capasity;
                }
            }
        }
        
        // Constructor
        public QueueWithArray()
        {
            elements = new T[capasity];
        }

        // Methods
        public T  this[int index]
        {
            get 
            {
                if (elements.Length > index && index >= 0)
                {
                    return elements[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
            set 
            {
                if (elements.Length > index && index >= 0)
                {
                    elements[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }    
            }
        }
       
        public void Enqueue(T element)
        {
            if (index == capasity)
            {
                capasity *= 2;
                T[] newArray = new T[capasity];
                for (int i = head; i <= tail; i++)
                {
                    newArray[i] = elements[i];
                }
                elements = newArray;
            }
            this.elements[index] = element;
            if (index == 0)
            {
                head = index;
                tail = index;
            }
            else
            {
                tail = index;
            }
            index++;
            count++;
        }

        public void Dequeue()
        {
            if (head > tail)
            {
                throw new IndexOutOfRangeException("No elements to dequene!");
            }
            elements[head] = default;
            count--;
            head = head + 1;

        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new Exception("No elements");
            }
            return this[head];
        }

        public void Clear()
        {
            count = 0;
            capasity = 2;
            head = 0;
            tail = 0;
            index = 0;
            elements = new T[capasity];
        }


    }
}
