using System;

namespace Chapter10Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoopN(3);

            Problem1(4);

        }

        public static void Problem1(int n)
        {
            ShitHappens(n, n);
        }

        private static void ShitHappens(int n, int counter, string prefix = "")
        {
            if (counter == 0)
            {
                Console.WriteLine(prefix);
                return;
            }

            for (int i = 1; i <= n; i++) 
            {
                ShitHappens(n, counter - 1, prefix + " " + i);
            }
        }

        public static void LoopN(int n)
        {
            int counter = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                counter++;
                if(counter <= n)
                {
                    LoopN(n);
                }
                if (counter == i)
                {
                    break;
                }

            }
        }
     }
}

