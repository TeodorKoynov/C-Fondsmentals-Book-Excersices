using System;
using System.Collections.Generic;

namespace Chapter16Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicStack<int> numbers = new DynamicStack<int>();
            numbers.Push(12);
            numbers.Push(14);
            numbers.Push(59);
            int[] array = numbers.ToArray();
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }


            //Excersice10();

            //Excersice9();

            //Excersice7();

            //Excersice6();

            //Excersice5();

            //Excersice4();

            //Excersice3();

            //Excersice2();

            //Excersice1();
        }

        private static void Excersice10()
        {
            int n = 3;
            int m = 11;
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(m);
            bool cantGoLowwer = false;
            Console.WriteLine(m);
            while (n <= m)
            {
                if (n != m)
                {
                    if (m / 2 < n)
                    {
                        cantGoLowwer = true;
                    }
                    if (m % 2 == 0 && m / 2 >= n)
                    {
                        m = m / 2;
                        Console.WriteLine(m);
                    }
                    else if (n < m && m % 2 != 0 && !cantGoLowwer)
                    {
                        m = m - 1;
                        Console.WriteLine(m);
                    }
                    if (m - 2 >= n && cantGoLowwer)
                    {
                        m = m - 2;
                        Console.WriteLine(m);
                    }
                    else if (cantGoLowwer)
                    {
                        m = m - 1;
                        Console.WriteLine(m);
                    }
                }
                else if (n == m)
                {
                    Console.WriteLine("Ready");
                    break;
                }
            }
        }


        private static void Excersice9()
        {
            Queue<int> numbers = new Queue<int>();
            int n = 2;
            numbers.Enqueue(n);
            Console.WriteLine(n);
            bool change = false;
            int baseNum = 1;
            while (numbers.Count <= 50)
            {
                numbers.Enqueue(n + 1);
                Console.WriteLine(n + 1);
                numbers.Enqueue(2 * n + 1);
                Console.WriteLine(2 * n + 1);
                numbers.Enqueue(n + 2);
                Console.WriteLine(n + 2);
                if (!change)
                {
                    n = n + 1;
                    change = true;
                    baseNum = 2;
                }
                else if (baseNum == 2)
                {
                    n = (n - 1) * 2 + 1;
                    baseNum = 3;
                }
                else if (baseNum == 3)
                {
                    n = (n - 1) / 2 + 2;
                    baseNum = 1;
                    change = false;
                }
            }
        }

        private static void Excersice7()
        {
            int[] numArr = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            List<int> numInOrder = new List<int>(numArr);
            numInOrder.Sort();
            List<int> foundNums = new List<int>();

            for (int i = 0; i < numInOrder.Count; i++)
            {
                int uniqueNum = numInOrder[i];
                if (!foundNums.Contains(uniqueNum))
                {
                    foundNums.Add(uniqueNum);
                }
                else
                {
                    continue;
                }
                int count = 0;
                int maxCount = 0;

                for (int j = 0; j < numInOrder.Count; j++)
                {
                    if (numInOrder[i] == numInOrder[j])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                    }
                }
                Console.WriteLine($"{uniqueNum} is fount {maxCount} times");

            }
        }

        private static void Excersice6()
        {
            int[] numArr = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            List<int> editedList = new List<int>(numArr);
            int counter = 0;
            int uniqueNum = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = 0; j < numArr.Length; j++)
                {
                    if (numArr[i] == numArr[j])
                    {
                        uniqueNum = numArr[i];
                        counter++;
                    }
                }
                if (counter % 2 != 0)
                {
                    editedList.Remove(uniqueNum);
                }
                counter = 0;
            }
            foreach (int number in editedList)
            {
                Console.WriteLine(number);
            }
        }

        private static void Excersice5()
        {
            List<int> numbers = new List<int>();
            string line = Console.ReadLine();
            while (line != "")
            {
                int number = int.Parse(line);
                if (number > 0)
                {
                    numbers.Add(number);
                }
                line = Console.ReadLine();
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void Excersice4()
        {
            string line = Console.ReadLine();
            List<int> numbers = new List<int>();
            while (line != "")
            {
                numbers.Add(int.Parse(line));
                line = Console.ReadLine();
            }
            numbers.Sort();
            int count = 1;
            int maxCount = 1;
            int number = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            List<int> rowOfNum = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                rowOfNum.Add(number);
                Console.WriteLine(number);
            }
        }

        private static void Excersice3()
        {
            List<int> numbers = new List<int>();
            string line = Console.ReadLine();
            while (line != "")
            {
                if (int.Parse(line) < 1)
                {
                    throw new Exception("Number must be > 0");
                }
                numbers.Add(int.Parse(line));
                line = Console.ReadLine();
            }
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void Excersice2()
        {
            string line = Console.ReadLine();
            Stack<int> numbers = new Stack<int>();
            while (line != "")
            {
                numbers.Push(int.Parse(line));
                line = Console.ReadLine();
            }
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }

        private static void Excersice1()
        {
            List<int> numbers = new List<int>();
            int sum = 0;
            int mathHalf = 0;
            string line = Console.ReadLine();
            while (line != "")
            {
                numbers.Add(int.Parse(line));
                line = Console.ReadLine();
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            mathHalf = sum / numbers.Count;
            Console.WriteLine($"the sum is {sum} and the halfMath is {mathHalf}");
        }
    }
}
