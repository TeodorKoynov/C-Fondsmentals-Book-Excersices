using System;

namespace Chapter6Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //233
            // Trash();
            // Excersice 10
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= n; i++)
            { 
                for(int j = 1; j <= n; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
                num = i + 1;
            }
            
        }

        private static void Trash()
        {
            //5
            int lastPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("____________________");
            int num1 = 0;
            int num2 = 1;
            int sum = num1;
            Console.WriteLine(num1);
            for (int i = 1; i < lastPosition; i++)
            {
                sum += num2;
                Console.WriteLine(num2);
                int swap = num2;
                num2 = num1 + num2;
                num1 = swap;
            }
            Console.WriteLine("____________________");
            Console.WriteLine(sum);
            // Excercise 1

            int baseNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= baseNum; i++)
            {
                Console.WriteLine(i);
            }

            // Excercise 2
            int startNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= startNum; i++)
            {
                if (i % (3 * 7) == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            // Excersice 3

            int n = int.Parse(Console.ReadLine());
            int bigNum = 0;
            int smallNum = 0;
            for (int i = 1; i <= n; i++)
            {
                //int num1 = int.Parse(Console.ReadLine());
               // if (num1 > bigNum)
                {
                    bigNum = num1;
                }
                if (num1 < smallNum)
                {
                    smallNum = num1;
                }
            }
            Console.WriteLine(bigNum + " " + smallNum);
            // Excercise 4
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 14; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
           }
            // Excercise 6
           // int n = int.Parse(Console.ReadLine());
            int nFactor = 1;
            int doubleN = 2 * n;
            int doubleNFactor = 1;
            int nPlusOne = n + 1;
            int nPlusOneFactor = 1;

            while (n >= 1)
            {
                nFactor *= n;
                n--;
            }
            Console.WriteLine(nFactor);

            while (doubleN >= 1)
            {
                doubleNFactor *= doubleN;
                doubleN--;
            }
            Console.WriteLine(doubleNFactor);


            while (nPlusOne >= 1)
            {
                nPlusOneFactor *= nPlusOne;
                nPlusOne--;
            }
            Console.WriteLine(nPlusOneFactor);
            Console.WriteLine(doubleNFactor / (nPlusOneFactor * nFactor));

            // Excercise 9
           // double n = int.Parse(Console.ReadLine());
            double x = int.Parse(Console.ReadLine());
            double factorN = 1;
            double xPow = 1;
            double poweredX = 1;
          //  double sum = 1;

            for (int i = 1; i <= n; i++, xPow++)
            {
                factorN *= i;
                poweredX = Math.Pow(x, xPow);

                Console.WriteLine("{0} / {1}", factorN, poweredX);
              //  sum += (factorN / poweredX);
            }
            Console.WriteLine(sum);
        }

    }
}
