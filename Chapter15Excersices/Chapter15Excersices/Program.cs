using System;
using System.Collections.Generic;
using System.IO;

namespace Chapter15Excersices
{
    class Program
    {
        static void Main(string[] args)
        {



            //Excersice7();

            //Excersice6();

            // Trash();
        }

        private static void Excersice7()
        {
            try
            {
                StreamReader reader = new StreamReader("SwapStart.txt");
                StreamWriter writer = new StreamWriter("FinishText.txt");
                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        string newLine = "";
                        bool move = true;
                        while (line != null)
                        {
                            move = true;
                            if (line.Contains("start"))
                            {
                                int index = line.IndexOf("start");
                                if (line.Length == index + 5)
                                {
                                    newLine = line.Replace("start", "finish");
                                    writer.WriteLine(newLine);
                                    move = false;
                                    line = reader.ReadLine();
                                }
                                if (move)
                                {
                                    if (line[index + 5] == ' ')
                                    {
                                        newLine = line.Replace("start", "finish");
                                        writer.WriteLine(newLine);
                                        line = reader.ReadLine();
                                    }
                                    else
                                    {
                                        writer.WriteLine(line);
                                        line = reader.ReadLine();
                                    }
                                }
                                else if (move == true)
                                {
                                    writer.WriteLine(line);
                                    line = reader.ReadLine();
                                }
                            }
                            else
                            {
                                writer.WriteLine(line);
                                line = reader.ReadLine();
                            }
                        }


                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void Excersice6()
        {
            try
            {
                StreamReader reader = new StreamReader("listNames.txt");
                int number = 1;
                List<string> listOfNames = new List<string>();
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        listOfNames.Add(line);
                        line = reader.ReadLine();
                        number++;
                    }
                }
                string[] names = new string[number];
                listOfNames.Sort();
                for (int i = 0; i < listOfNames.Count; i++)
                {
                    names[i] = listOfNames[i];
                }
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void Trash()
        {
            // Excersices 5
            try
            {
                StreamReader reader1 = new StreamReader("text.txt");
                int matrixLenght = int.Parse(reader1.ReadLine());
                int[,] matrix = new int[matrixLenght, matrixLenght];
                string line = "";
                string[] numbers = new string[matrixLenght];
                using (reader1)
                {
                    for (int i = 0; i < matrixLenght; i++)
                    {
                        line = reader1.ReadLine();
                        numbers = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < matrixLenght; j++)
                        {
                            matrix[i, j] = int.Parse(numbers[j]);
                        }
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
