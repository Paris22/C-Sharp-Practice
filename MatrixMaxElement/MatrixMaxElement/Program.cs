using System;

namespace MatrixMaxElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsNumber = 10;
            int columnsNumber = 10;
            int[,] matrix = new int[rowsNumber, columnsNumber];
            int maxElement = int.MinValue;

            Random random = new Random();
            int randomLimit = 10;

            Console.WriteLine("Исходная матрица:");
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    matrix[rows, columns] = random.Next(randomLimit);
                    Console.Write(matrix[rows, columns] + " ");
                }

                Console.WriteLine();
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    if (matrix[rows, columns] > maxElement)
                    {
                        maxElement = matrix[rows, columns];
                    }
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    if (matrix[rows, columns] == maxElement)
                    {
                        matrix[rows, columns] = 0;
                    }
                }
            }

            Console.WriteLine($"Максимальный элемент: {maxElement}");

            Console.WriteLine("Матрица после замены максимального элемента на ноль:");
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    Console.Write(matrix[rows, columns] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
