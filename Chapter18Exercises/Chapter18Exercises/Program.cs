using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter18Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2, 10, 10 };
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            foreach (int number in array)
            {
                int count = 0;
                if (!numbers.ContainsKey(number))
                {
                    int currentElement = number;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == currentElement)
                        {
                            count++;
                        }
                    }
                    if (count % 2 == 0)
                    {
                        numbers.Add(number, count);
                    }
                }
            }

        }
    }
}
