using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter16Excersices
{
    class Deck<T>
    {
        // Fields
        private DynamicStack<T> top = null;
        private DynamicStack<T> bottom = null;
        private int count = 0;

        // Properties
        public int Counter
        {
            get { return count; }
        }

        // Constructor
        public Deck()
        {
            top = new DynamicStack<T>();
            bottom = new DynamicStack<T>();
        }

        // Methods
        public void AddToTop(T element)
        {
            top.Push(element);
            count++;
        }
        public void AddToBottom(T element)
        {
            bottom.Push(element);
            count++;
        }
        public T DrawFromTop()
        {
            count--;
            return top.Pop();
        }
        public T DrawFromBottom()
        {
            count--;
            return bottom.Pop();
        }
        public void Clear()
        {
            top.Clear();
            bottom.Clear();
            count = 0;
        }
        
    }
}
