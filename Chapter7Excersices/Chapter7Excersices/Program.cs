using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.ComTypes;

namespace Chapter7Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lol();
            //Trash();
            //SelectionSort()
            //FindTheExactSum();
            // int[,] array = new int[5, 5];
            // GettingA(array);
            // GettingB(array);
            // GettingC(array);
            // GettingD(array);
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[][] array = new int[n][];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new int[m];
                for(int j = 0; j < array.Length; i++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < array.Length - 3; i++)
            {
                for(int j = 0; j < array[0].Length - 3; j++)
                {

                }
            }

        }

        private static void GettingD(int[,] array)
        {
            int bottom = array.GetLength(0);
            int col = 0;
            int num = 1;
            int row;
            int top = 0;
            int leftIndex = 1;
            bool moveDown = true;
            bool moveRight = false;
            bool moveUp = false;
            bool moveLeft = false;
            int zero = 0;
            int n = 0;
            int zeroLeft = 0;
            int rightPosition = array.GetLength(0) - 1;
            int colIndexRight = array.GetLength(0) - 1;
            int colLeftPositon = array.GetLength(0) - 1;
            int rowUpPosition = array.GetLength(0) - 2;
            int leftPosition = array.GetLength(1) - 2;
            while (num <= (array.GetLength(0) * array.GetLength(1)))
            {
                // Move Down
                if (moveDown == true)
                {
                    int col1 = zero;
                    int i = zero;
                    for (int row1 = i; row1 < bottom; row1++)
                    {
                        array[row1, col1] = num++;
                    }
                    zero++;
                    bottom--;
                    moveDown = false;
                    moveRight = true;
                }

                // Move Right
                if (moveRight == true)
                {
                    int bottomIndexRight = rightPosition;
                    for (int colRight = col + 1; colRight < array.GetLength(1) - n; colRight++)
                    {
                        array[bottomIndexRight, colRight] = num++;
                    }
                    n++;
                    col++;
                    moveUp = true;
                    moveRight = false;
                    rightPosition--;
                }

                // Move Up
                if (moveUp == true)
                {
                    int col1 = colLeftPositon;
                    int topIndexUp = rowUpPosition;
                    for (row = topIndexUp; row >= top; row--)
                    {
                        if (num > (array.GetLength(0) * array.GetLength(1)))
                        {
                            break;
                        }
                        array[row, col1] = num++;

                    }
                    colLeftPositon--;
                    top++;
                    moveUp = false;
                    moveLeft = true;
                    rowUpPosition--;
                }


                // Move Left
                if (moveLeft == true)
                {

                    int topIndexLeft = zeroLeft;
                    int col2 = leftPosition;
                    for (int col1 = col2; col1 >= leftIndex; col1--)
                    {
                        if (num > (array.GetLength(0) * array.GetLength(1)))
                        {
                            break;
                        }
                        array[topIndexLeft, col1] = num++;
                    }
                    leftIndex++;
                    leftPosition--;
                    moveLeft = false;
                    moveDown = true;
                    zeroLeft++;
                }

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
        }

        private static int[,] CoolToShit(int[][] matrix)
        {
            if (matrix.Length == 0)
            {
                return new int[0, 0];
            }

            int[,] shit = new int[matrix.Length, matrix[0].Length];

            for (int i = 0; i < shit.GetLength(0); i++)
            {
                for (int j = 0; j < shit.GetLength(1); j++)
                {
                    shit[i, j] = matrix[i][j];
                }
            }

            return shit;
        }

        private static int[][] GetDefaultMatrix(int size)
        {
            int[][] matrix = new int[size][];
            int num = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[size];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = num++;
                }
            }

            return matrix;
        }

        private static int[][] GetEmptyMatrix(int size)
        {
            int[][] matrix = new int[size][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[size];
            }

            return matrix;
        }

        private static int[][] GetEmptyMatrix(int rowSize, int colSize)
        {
            int[][] matrix = new int[rowSize][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[colSize];
            }

            return matrix;
        }

        private static void InitMatrixC(int[][] matrix)
        {
            int num = 1;

            for (int i = matrix.Length - 1; i >= 0 ; i--)
            {
                for (int col = 0; col < matrix[i].Length - i; col++)
                {
                    int row = col + i;
                    matrix[row][col] = num++;
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                int row = 0;
                int col = i;
                while (col < matrix.Length)
                {
                    matrix[row++][col++] = num++;
                }
            }
        }


        private static void Print(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void GettingC(int[,] array)
        {
            int counter = 0;
            int num = 1;
            int row = 0;

            for (int i = array.GetLength(0) - 1; i >= 0; i--)
            {
                row = i;
                for (int j = 0; j <= counter; j++)
                {
                    array[row, j] = num;
                    num++;
                    row++;
                }
                counter += 1;
            }
            //int col
            int numTop = array.GetLength(0) * array.GetLength(1);
            counter = 1;
            int col = 3;
            row = 0;
            int adition = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                row = +adition;
                col = array.GetLength(1) - 1;
                for (int j = 1; j <= counter; j++)
                {
                    if (numTop == num - 1)
                    {
                        break;
                    }
                    array[row, col] = numTop;
                    numTop--;

                    row--;
                    col--;

                }
                adition += 1;
                counter += 1;
                if (numTop == 10)
                {
                    break;
                }
            }


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        private static void GettingB(int[,] array)
        {
            bool fromTop = true;
            int num = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (fromTop == true)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[j, i] = num;
                        num++;
                    }
                    fromTop = false;

                }
                else
                {
                    for (int k = array.GetLength(0) - 1; k >= 0; k--)
                    {
                        array[k, i] = num;
                        num++;
                    }
                    fromTop = true;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        private static void GettingA(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int num = i + 1;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = num;
                    num += array.GetLength(0);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        private static void FindTheExactSum()
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int sum = 0;
            int startIndex = 0;
            int endIndex = 0;
            int expectedSum = 2;
            for (int i = 0; i < array.Length; i++)
            {
                sum = array[i];

                if (sum == expectedSum)
                {
                    Console.WriteLine(array[i]);
                    Console.WriteLine(" ");
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    sum += array[j];

                    if (sum == expectedSum)
                    {
                        startIndex = i;
                        endIndex = j;
                        while (startIndex <= endIndex)
                        {
                            Console.WriteLine(array[startIndex] + " ");
                            startIndex++;
                        }
                        Console.WriteLine(" ");
                    }
                }
                sum = 0;
            }
        }

        private static void SelectionSort()
        {
            int[] array = { 2, 4, 1, 5, 3, 7, 9, 8, 1, 10, 2, 14, 1, 2545, 53 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int swap;
                    if (array[j] < array[i])
                    {
                        swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void Lol()
        {
            //Excercise 7
            int n = int.Parse(Console.ReadLine());
            int followNum = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            int maxSum = 0;
            int presentNum = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= n - followNum; i++)
            {
                presentNum = i;
                for (int j = 0; j < followNum; j++)
                {
                    sum += array[presentNum];
                    presentNum++;
                }
                if (maxSum <= sum)
                {
                    maxSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine(maxSum);
        }

        private static void Trash()
        {
            int[] arr = new int[20];
            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = index * 5;
                Console.WriteLine("Array[{0}] = {1}", index, arr[index]);
            }
            int length1 = int.Parse(Console.ReadLine());
            int length2 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length1];
            int[] arr2 = new int[length2];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {

                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Not equal!");
                    break;
                }
                int[] array = { 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 1, 2, 1, 1, 1, 1, 1, 1 };
                int baseNum = array[0];
                int counter = 0;
                int startIndex = 0;
                int endIndex = 0;
                int maxCounter = 0;
               // for (int j = 1; i < array.Length; i++)
                {
                    if (baseNum == array[i])
                    {
                        counter += 1;
                    }
                    else
                    {
                        baseNum = array[i];
                        counter = 0;
                    }
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        endIndex = i;
                        startIndex = endIndex - counter;
                    }
                }
                int[] array1 = { 3, 2, 3, 4, 5, 2, 2, 4, 1, 2, 1, 3, 4, 5, 1 };
          //  int baseNum1 = array[0];
            //int count11er = 0;
          //  int startIn11dex = 0;
          //  int endIndex1 = 0;
          //  int maxCou1nter = 0;
           // for(int i = 1; i < array.Length; i++)
            {
                if(baseNum == array[i] - 1)
                {
                    counter += 1;
                }
                else
                {
                    counter = 0;
                }

                baseNum = array[i];

                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    endIndex = i;
                    startIndex = endIndex - maxCounter;
                }
            }
            while(startIndex <= endIndex)
            {
                Console.WriteLine(array[startIndex]);
                startIndex++;
            }
                while (startIndex <= endIndex)
                {
                    Console.WriteLine(array[startIndex]);
                    startIndex++;

                }
            }
        }
    }
}
