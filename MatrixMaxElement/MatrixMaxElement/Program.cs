using System;

namespace MatrixMaxElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];

            Random random = new Random();

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    matrix[rows, columns] = random.Next(10);
                    Console.Write(matrix[rows, columns] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
