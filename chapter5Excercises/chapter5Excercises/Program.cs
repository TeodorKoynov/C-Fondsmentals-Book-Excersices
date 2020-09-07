using System;
using System.Drawing;
using System.Timers;

namespace chapter5Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trash();

            int point1 = int.Parse(Console.ReadLine());
            int point2 = int.Parse(Console.ReadLine());
            int point3 = int.Parse(Console.ReadLine());
            int point4 = int.Parse(Console.ReadLine());
            int point5 = int.Parse(Console.ReadLine());
            int point6 = int.Parse(Console.ReadLine());
            int point7 = int.Parse(Console.ReadLine());
            int point8 = int.Parse(Console.ReadLine());
            int point9 = int.Parse(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                if(point1 == 0)
            }


        }
        private static void Trash()
        {
            // Exercise 1

            int biggerNumb = int.Parse(Console.ReadLine());
            int smallerNumb = int.Parse(Console.ReadLine());

            if (smallerNumb > biggerNumb)
            {
                int swap = smallerNumb;
                smallerNumb = biggerNumb;
                biggerNumb = swap;
            }
            Console.WriteLine($"{biggerNumb} > {smallerNumb}");

            // Excercise 2

            int numb1 = int.Parse(Console.ReadLine());
            int numb2 = int.Parse(Console.ReadLine());
            int numb3 = int.Parse(Console.ReadLine());
            if (numb1 < 0)
            {
                if (numb3 < 0 && numb2 < 0)
                {
                    Console.WriteLine("Negative Number");
                }
                else if (numb3 < 0 || numb2 < 0)
                {
                    Console.WriteLine("Positive Number");
                }
                else
                {
                    Console.WriteLine("Negative Number");
                }
            }
            else if (numb2 < 0)
            {
                if (numb3 < 0)
                {
                    Console.WriteLine("Positive Number");
                }
                else
                {
                    Console.WriteLine("Negative Number");
                }

            }
            else if (numb3 < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("All 3 are positive");
            }

            // Excercise 3
            int nomer1 = int.Parse(Console.ReadLine());
            int nomer2 = int.Parse(Console.ReadLine());
            int nomer3 = int.Parse(Console.ReadLine());

            if (nomer1 >= nomer2)
            {
                if (nomer1 >= nomer3)
                {
                    Console.WriteLine($"The biggest number is {nomer1}");
                }
                else
                {
                    Console.WriteLine($"The biggest number is {nomer3}");
                }
            }
            else if (nomer2 >= nomer3)
            {
                Console.WriteLine($"The biggest number is {nomer2}");
            }
            else
            {
                Console.WriteLine($"The biggest number is {nomer3}");
            }
            // Excercise 3
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int biggest = 0;
            int middle = 0;
            int lowest = 0;

            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    if (num3 >= num2)
                    {
                        biggest = num1;
                        middle = num3;
                        lowest = num2;
                    }
                    else
                    {
                        biggest = num1;
                        middle = num2;
                        lowest = num3;
                    }
                }
                else
                {
                    biggest = num3;
                    middle = num1;
                    lowest = num2;
                }
            }
            else if (num2 >= num3)
            {
                biggest = num2;
                if (num3 >= num1)
                {
                    middle = num3;
                    lowest = num1;
                }
                else
                {
                    middle = num1;
                    lowest = num3;
                }
            }
            else
            {
                biggest = num3;
                middle = num2;
                lowest = num1;
            }

            if (biggest == middle && biggest != lowest)
            {
                Console.WriteLine("The biggest == middle == {0}, the lowest == {1}", biggest, lowest);
            }
            else if (lowest == middle && lowest != biggest)
            {
                Console.WriteLine("The biggest == {0}, the middle == lowest == {1}", biggest, lowest);
            }
            else if (lowest == biggest && lowest == middle)
            {
                Console.WriteLine("The biggest = the middle = the lowest = {0}", lowest);
            }

            else
            {
                Console.WriteLine("The biggest is {0}, the middle is {1}, the lowest is {2}", biggest, middle, lowest);
            }

            // Excercise 5
           
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("Едно"); break;
                case 2: Console.WriteLine("Две"); break;
                case 3: Console.WriteLine("Три"); break;
                case 4: Console.WriteLine("Четири"); break;
                case 5: Console.WriteLine("Пет"); break;
                case 6: Console.WriteLine("Шест"); break;
                case 7: Console.WriteLine("Седем"); break;
                case 8: Console.WriteLine("Осем"); break;
                case 9: Console.WriteLine("Девет"); break;
                default: Console.WriteLine("Числото не е в диапазон от 1 до 9!"); break;
            }
            
            // Excercise 6

            float x1, x2 = 10f;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            float discriminant = 0f;

            discriminant = (float)Math.Pow(b, 2) - (4 * a * c);
            if (discriminant > 0)
            {
                x1 = ((-b) + (float)Math.Sqrt(discriminant)) / (2 * a);
                x2 = ((-b) - (float)Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (discriminant == 0)
            {
                x1 = -b / (4 * a);
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("x1 and x2 don't exsist");
            }
            // Excercise 7

            int nuamb1 = int.Parse(Console.ReadLine());
            int nuamb2 = int.Parse(Console.ReadLine());
            int nuamb3 = int.Parse(Console.ReadLine());
            int numb4 = int.Parse(Console.ReadLine());
            int numb5 = int.Parse(Console.ReadLine());

            if (numb1 > numb2 && numb1 > numb3 && numb1 > numb4 && numb1 > numb5)
            {
                Console.WriteLine("The biggest number is {0}", numb1);
            }
            else if (numb2 > numb3 && numb2 > numb4 && numb2 > numb5)
            {
                Console.WriteLine("The biggest number is {0}", numb2);
            }
            else if (numb3 > numb4 && numb3 > numb5)
            {
                Console.WriteLine("The biggest number is {0}", numb3);
            }
            else if (numb4 > numb5)
            {
                Console.WriteLine("The biggest number is {0}", numb4);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", numb5);
            }

            int test = 0;
            int number12 = 0;
            double numberDouble;
            string text = Console.ReadLine();

            if (double.TryParse(text, out numberDouble))
            {
                test = 1;
            }
            else if (int.TryParse(text, out number))
            {
                test = 2;
            }
            else
            {
                test = 3;
            }

            switch (test)
            {
                case 1: Console.WriteLine(numberDouble + 1); break;
                case 2: Console.WriteLine(number + 1); break;
                case 3: Console.WriteLine($"{text} *"); break;
                default: Console.WriteLine("Unknown!"); break;
            }

        }
    }

}
