using System;
using System.IO;

namespace Chapter15Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader1 = new StreamReader("text.txt");
                int matrixLenght = int.Parse(reader1.ReadLine());
                int[,] matrix = new int[matrixLenght, matrixLenght];
                string line = "";
                string[] numbers = new string[matrixLenght];
                    for (int i = 0; i < matrixLenght; i++)
                    {
                        line = reader1.ReadLine();
                        numbers = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < matrixLenght; j++)
                        {
                            matrix[i, j] = int.Parse(numbers[j]);
                        }
                    }
                // Methods
                PringMatrix(matrix);
                Console.WriteLine("");
                GetSubMarixWith2x2(matrix);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void PringMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine("");
            }
        }
        public static void GetSubMarixWith2x2(int[,] matrix)
        {
            int sum = 0;
            int maxSum = 0;
            int[,] subMatrix = new int[2, 2];
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        subMatrix[0, 0] = matrix[i, j];
                        subMatrix[0, 1] = matrix[i, j + 1];
                        subMatrix[1, 0] = matrix[i + 1, j];
                        subMatrix[1, 1] = matrix[i + 1, j + 1];
                    }
                }
            }
            for (int i = 0; i < subMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < subMatrix.GetLength(1); j++)
                {
                    Console.Write(subMatrix[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("___________________");
            Console.WriteLine(maxSum);
        }
    }
}
