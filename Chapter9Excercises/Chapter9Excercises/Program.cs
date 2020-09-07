using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Chapter9Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            switch (num)
            {
                case 1:
                    int number = 240;
                    Console.WriteLine(RevurseNumber(number));
                    break;

                case 2:
                    int[] array = { 2, 3, 4, 5 };
                    Console.WriteLine(GetBetweenSum(array));
                    break;
                
                case 3:
                    Console.WriteLine(CalculateX(3, 9));
                    break;
                default:
                    Console.WriteLine("Invalid Number!");
                    break;
            }

            Console.WriteLine(CalculateFactor(5));
        }
        public static void PringGreatings(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }

        public static int GetBiggerNumber(int number1, int number2)
        {
            int max = number1;
            if (max < number2)
            {
                max = number2;
            }
            return max;
        }

        public static int GetLastDiged(int number)
        {
            string str = number.ToString();
            str = str[str.Length - 1].ToString();
            number = int.Parse(str);
            return number;
        }

        public static void PrintNumberName(int number)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;

                case 1:
                    Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 4:
                    Console.WriteLine("Four");
                    break;

                case 5:
                    Console.WriteLine("Five");
                    break;

                case 6:
                    Console.WriteLine("Six");
                    break;

                case 7:
                    Console.WriteLine("Seven");
                    break;

                case 8:
                    Console.WriteLine("Eight");
                    break;

                case 9:
                    Console.WriteLine("Nine");
                    break;

                default:
                    Console.WriteLine("Exception! There is not a number!");
                    break;
            }
        }

        public static int GetCount(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }
            return count;
        }

        public static void CheckPosition(int[] array, int number)
        {
            int baseNum = array[number];
            int leftNum = array[number - 1];
            int rightNum = array[number + 1];
            bool biggerThanLeft = false;
            bool biggerThenRight = false;
            if (baseNum > leftNum)
            {
                biggerThanLeft = true;
            }

            if (baseNum > rightNum)
            {
                biggerThenRight = true;
            }

            if (biggerThanLeft && biggerThenRight == true)
            {
                Console.WriteLine($"{baseNum} is bigger than left num: {leftNum} right num: {rightNum}");
            }
            if (biggerThanLeft == false && biggerThenRight == false)
            {
                Console.WriteLine($"{baseNum} is smaller than left num: {leftNum} right num: {rightNum}");
            }
            if (biggerThanLeft == true && biggerThenRight == false)
            {
                Console.WriteLine($"{baseNum} is bigger than left num: {leftNum} but smaller than right num: {rightNum}");
            }
            if (biggerThanLeft = false && biggerThenRight == true)
            {
                Console.WriteLine($"{baseNum} is smaller than left num: {leftNum} but bigger than right num: {rightNum}");
            }
        }

        public static int ReturnPosition(int[] array)
        {
            int baseNum, leftNum, rightNum;
            int index = -1;
            for (int i = 1; i < array.Length - 1 ; i++)
            {
                baseNum = array[i];
                leftNum = array[i - 1];
                rightNum = array[i + 1];

                if(baseNum > rightNum && baseNum > leftNum)
                {
                    index = i;
                }
            }
            return index;
        }

        public static void PrintNumBackwards(int number)
        {
            string newNum = "";
            while (number != 0)
            {
                newNum += (number % 10).ToString();
                number = number / 10;
            }
            Console.WriteLine(newNum);
        }

        public static int SumArrays(int[] array1, int[] array2)
        {
            if(array1.Length > 1001 || array2.Length > 1001)
            {
                Console.WriteLine("Elements over 1000!");
            }
            int sum = 0;
            int num1 = 0;
            int num2 = 0;
            int decimalIndex = 1;

            for(int i = 0; i < array1.Length; i++)
            {
                num1 += array1[i] * decimalIndex;
                decimalIndex *= 10;
            }

            decimalIndex = 1;

            for (int i = 0; i < array2.Length; i++)
            {
                num2 += array2[i] * decimalIndex;
                decimalIndex *= 10;
            }

            sum = num1 + num2;
            return sum;
        }

        public static void PringFactor(int number)
        {
            int sum = 1;
            for (int i = number; i > 0; i--)
            {
                sum *= i;
                Console.Write($"{i} ");
                if(i > 1)
                {
                    Console.Write("* ");
                }
            }
            Console.Write($"= {sum}");
        }

        public static int RevurseNumber(int number)
        {
            if(number < 0)
            {
                Console.WriteLine("Invalid number!");
            }
            string num = number.ToString();
            num = string.Join("", num.Reverse().ToArray());
            int newNumber = int.Parse(num);
            return newNumber;
        }
    
        public static int GetBetweenSum(params int[] number)
        {
            if(number == null)
            {
                Console.WriteLine("No numbers!");
            }
            int finalSum = 0;
            int sum = 0;
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
                count++;
            }
            finalSum = sum / count;
            return finalSum;
        }
    
        public static int CalculateX(int a, int b)
        {
            if(a == 0)
            {
                Console.WriteLine("a can not be 0!");
            }
            // a * x + b = 0
            // x = -b / a

            int x = -b / a;
            return x;
        }

        public static int CalculateFactor(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactor(number - 1);
            }
        }
    }


}
