using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Chapter3Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            // BinDoNotOpen();

            Problem12();

        }

        private static void Problem12()
        {
            
        }

        private static void BinDoNotOpen()
        {
            // Excersice 1
            string num = Console.ReadLine();
            int number = int.Parse(num);

            if (number % 2 == 1)
            {
                Console.WriteLine("The number is odd");
            }
            else
            {
                Console.WriteLine("The number is even");
            }

            // Excersice 2
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("The number is devidable by 5 and 7");
            }
            // Excersice 3
            int devidedNum = number / 100;
            if ((devidedNum - 7) % 10 == 0)
            {
                Console.WriteLine("In third position is 7");
            }

            // Excersice 4

            // Gets the binary number
            string binary = "";
            int binaryNum = number;

            while (binaryNum >= 1)
            {
                binary += binaryNum % 2;

                binaryNum = binaryNum / 2;
            }

            /*
            for(int i = 0; binaryNum >= 1; i++)
            {   
                if (binaryNum % 2 == 1)
                {
                    binary += "1";
                }
                else
                    binary += "0";
            
                binaryNum = binaryNum / 2;
            }
            */

            string str = string.Join("", binary.Reverse());
            Console.WriteLine(str);

            // Revureses the binary  number
            string newBinary = "";
            for (int j = binary.Length - 1; j >= 0; j--)
            {
                newBinary += binary[j];
            }
            Console.WriteLine(newBinary);

            // Checks whether the 3rd diget is "0" or "1"
            binaryNum = int.Parse(newBinary);
            binaryNum = binaryNum / 100;

            int digit = binaryNum % 2;
            Console.WriteLine($"The third diget is {digit}");

            /*
            if (binaryNum % 2 == 0)
            {
                Console.WriteLine("The third diget is 0");
            }
            else
                Console.WriteLine("The third diget is 1");
            */

            // Excersice 5
            Console.WriteLine("__________________________________");
            Console.WriteLine("Please, enter the value of \'a\'.");
            string a = Console.ReadLine();
            Console.WriteLine("Please, enter the value of \'b\'.");
            string b = Console.ReadLine();
            Console.WriteLine("Please, enter the value of \'h\'.");
            string h = Console.ReadLine();

            float area = (float.Parse(a) + float.Parse(b)) * float.Parse(h) / 2;
            Console.WriteLine(@$"
The area is {area}.");

            // Excersice 6
            Console.WriteLine("____________________________________");
            Console.WriteLine("Please, enter the value of AB");
            string ab = Console.ReadLine();
            Console.WriteLine("Please, enter the value of CD");
            string cd = Console.ReadLine();

            float areaOfRectangle = float.Parse(ab) * float.Parse(cd);
            Console.WriteLine($"The area of the Rectangle has value of {areaOfRectangle}");

            float perimeter = (float.Parse(ab) + float.Parse(cd)) * 2;
            Console.WriteLine($"The perimeter of the Rectangle has value of {perimeter}");

            // Excersice 7

            Console.WriteLine("_____________________________________");
            Console.WriteLine("Please, enter weight: ");
            string weightOnEarth = Console.ReadLine();

            float weightOnMoon = float.Parse(weightOnEarth) * 0.17f;
            Console.WriteLine($"The weight on the Moon is going to be {weightOnMoon}");

            // Excersice 8

            Console.WriteLine("_____________________________________");
            Console.WriteLine("Please enter \"x\"");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter \"y\"");
            int y = int.Parse(Console.ReadLine());
            bool insideCircle = (Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2)) <= 25;
            Console.WriteLine("Point inside Circle? {0}", insideCircle);

            // Excersice 9
            bool insideRectangle;
            if (x >= -1 && x <= 5 && y >= 1 && y <= 5) // Checks whether the point codinates are inside the rectangle ones
            {
                insideRectangle = true;
                if (insideCircle == true) // Could be done better logic
                {
                    Console.WriteLine("The point is in the circle and the rectangle");
                }
                else
                {
                    Console.WriteLine("The point is outside the circle but in the rectangle");
                }
            }
            else
            {
                if (insideCircle == true)
                {
                    Console.WriteLine("The point is in the circle but outside the rectangle");
                }
                else
                {
                    Console.WriteLine("The point is outside the circle and the rectangle");
                }
            }

            // Excersice 10
            Console.WriteLine("Please enter a 4 diged number");
            int number4Diged = int.Parse(Console.ReadLine());

            int forthD = number4Diged / 1000;
            int thirdD = (number4Diged / 100) - (forthD * 10);
            int secondD = (number4Diged / 10) - ((forthD * 100) + (thirdD * 10));
            int firstD = number4Diged - ((forthD * 1000) + (thirdD * 100) + (secondD * 10));
            Console.WriteLine($"The first diged is {firstD}, the second is {secondD}, the third is {thirdD} and the forth is {forthD}");

            int sumOfDigeds = firstD + secondD + thirdD + forthD;
            Console.WriteLine($"The sum of digeds is {sumOfDigeds}");

            Console.WriteLine(firstD.ToString() + forthD.ToString() + thirdD.ToString() + secondD.ToString());

            Console.WriteLine(firstD.ToString() + thirdD.ToString() + secondD.ToString() + forthD.ToString());

            Console.WriteLine(forthD.ToString() + secondD.ToString() + thirdD.ToString() + firstD.ToString());

            // Excersice 11
            int numberN = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            // Gets the binary number
            string binaryN = "";

            while (numberN >= 1)
            {
                binaryN += numberN % 2;

                numberN = numberN / 2;
            }

            // Revureses the binary  number
            string newBinaryN = "";
            for (int j = binaryN.Length - 1; j >= 0; j--)
            {
                newBinaryN += binaryN[j];
            }
            Console.WriteLine(newBinaryN);

            if (p > binaryN.Length)
            {
                Console.WriteLine("The position of p is too large!");
            }
            else
            {
                Console.WriteLine($"The bit on position p {p} is {newBinaryN[newBinaryN.Length - p]}");
            }
        }
    }
}
