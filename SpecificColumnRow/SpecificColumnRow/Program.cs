using System;

namespace SpecificColumnRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int rowsNumber;
                int columnsNumber;
                int sumSecondRow = 0;
                int productFirstColumn = 1;
                int randomLimit = 10;
                Random random = new Random();

                Console.WriteLine("Введите кол-во строк в матрице");
                rowsNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов в матрице");
                columnsNumber = Convert.ToInt32(Console.ReadLine());

                int[,] matrix = new int[rowsNumber, columnsNumber];


                if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 1)
                {
                    Console.WriteLine("Массив должен содержать как минимум 2 строки и 1 столбец.");
                    return;
                }

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

                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    sumSecondRow += matrix[1, columns];
                }

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    productFirstColumn *= matrix[rows, 0];
                }

                Console.WriteLine("Сумма второй строки: " + sumSecondRow);
                Console.WriteLine("Произведение первого столбца: " + productFirstColumn);
            }
        }
    }
}
