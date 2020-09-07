using System;
using System.Numerics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Chapter4Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trash();

            // Excercise 13
            float number1 = 1f;
            float number2 = 1f;
            float betweenSum = 1f;

            for(int i = 0; i < 15; i++)
            {
                number2 = number2 / 2;
                betweenSum += number2;
                number1 = number2;
 
            }
            Console.WriteLine(betweenSum);
            Console.WriteLine("{0:0.000}", betweenSum);
            Console.WriteLine(Math.Round(betweenSum, 3));
            

        }

        private static void Trash()
        {
            //Excercise 1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("1: {0}, 2: {1}, 3: {2}", a, b, c);

            // Excersice 2

            int r = int.Parse(Console.ReadLine());
            float s = (float)(Math.PI * Math.Pow(r, 2));
            float p = (float)(Math.PI * r * 2);
            Console.WriteLine("The S: {0}, the P: {1}", s, p);

            // Excersice 3

            // name, adress, phone number, fax number, web site, manager

            string nameCorp = Console.ReadLine();
            string adress = Console.ReadLine();
            string phoneNumCorp = Console.ReadLine();
            string faxNumber = Console.ReadLine();

            // name, lastName, phone number

            // Excersice 4
            Console.WriteLine("{0 , 10:X}  {1 , 10}  {2, 10}", 1412, 12.2, -12.21);

            // Excersice 5
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int numberCounter = 0;

            if (number2 <= number1)
            {
                int swap = number1;
                number1 = number2;
                number2 = number1;
            }

            for (int i = number1; i <= number2; i++)
            {
                if (i % 5 == 0)
                {
                    numberCounter += 1;
                }
            }
            Console.WriteLine(numberCounter);

            // Excersice 6

           // int number1 = int.Parse(Console.ReadLine());
         //   int number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(number1 > number2 ? "{0} is bigger than {1}" : "{1} is bigger than {0}", number1, number2);

            // Excersice 7
            int numbera1, number2a, number3a, numbera4, number5 = 0;
            bool try1, try2, try3, try4, tary5;

            try1 = int.TryParse(Console.ReadLine(), out number1);
            if (try1 == false)
            {
                while (try1 == false)
                {
                    Console.WriteLine("Please, enter a valid number!");

                    try1 = int.TryParse(Console.ReadLine(), out number1);
                }
            }

            try2 = int.TryParse(Console.ReadLine(), out number2);
            if (try2 == false)
            {
                while (try2 == false)
                {
                    Console.WriteLine("Please, enter a valid number!");

                    try2 = int.TryParse(Console.ReadLine(), out number2);
                }
            }

            try3 = int.TryParse(Console.ReadLine(), out numbera4);
            if (try3 == false)
            {
                while (try3 == false)
                {
                    Console.WriteLine("Please, enter a valid number!");

                    try3 = int.TryParse(Console.ReadLine(), out numbera4);
                }
            }

            try4 = int.TryParse(Console.ReadLine(), out numbera4);
            if (try4 == false)
            {
                while (try4 == false)
                {
                    Console.WriteLine("Please, enter a valid number!");

                    try4 = int.TryParse(Console.ReadLine(), out numbera4);
                }
            }

            try4 = int.TryParse(Console.ReadLine(), out number5);
            if (try4 == false)
            {
                while (try4 == false)
                {
                    Console.WriteLine("Please, enter a valid number!");

                    try4 = int.TryParse(Console.ReadLine(), out number5);
                }
            }
            int sum = number1 + number2 + number2 + number2 + number5;
            Console.WriteLine(sum);

            // Excersice 8

            int firstMax, secondMax, thirdMax, fourthMax = 0;

            int numbe2r1 = int.Parse(Console.ReadLine());
            int numb2er2 = int.Parse(Console.ReadLine());
            int nu2mber3 = int.Parse(Console.ReadLine());
            int num2ber4 = int.Parse(Console.ReadLine());
            int numb2er5 = int.Parse(Console.ReadLine());

            firstMax = Math.Max(number1, number2);
            secondMax = Math.Max(number1, number1);
            thirdMax = Math.Max(firstMax, secondMax);
            fourthMax = Math.Max(thirdMax, number5);

            Console.WriteLine(fourthMax);

            // Excersice 9

          //  int a = int.Parse(Console.ReadLine());
           // int b = int.Parse(Console.ReadLine());
           // int c = int.Parse(Console.ReadLine());
            int x1 = 0;
            int x2 = 0;

            int descriminat = (b * b) - (4 * a * c);


            if (descriminat < 0)
            {
                Console.WriteLine("x1 and x2 do not exsist");
            }
            if (descriminat == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x1 = x1 = {0}", x1);
            }
            if (descriminat > 0)
            {
                x1 = (-b + (int)Math.Sqrt(descriminat)) / 2 * a;
                x2 = (-b - (int)Math.Sqrt(descriminat)) / 2 * a;
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }

            // Excercise 10

            int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum is {sum}");

            // Excersice 11

            //int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            // Excercise 12

           // long number1 = 0;
            //long number2 = 1;
           // long sum = 0;
           // Console.WriteLine($"Number1 = {number1}");
           // Console.WriteLine($"Number2 = {number2}");

            //for (int i = 3; i <= 100; i++)
           // {
           //     sum = number1 + number2;
           //     number1 = number2;
           //     number2 = sum;
           //     Console.WriteLine($"Number{i} = {sum}");
           //     sum = 0;
           // }


        }
    }
}
