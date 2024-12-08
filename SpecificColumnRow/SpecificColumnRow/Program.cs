using System;

namespace SpecificColumnRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[,] multiDimesionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };

                int sumSecondRow = multiDimesionalArray[1, 0] + multiDimesionalArray[1, 1] + multiDimesionalArray[1, 2];
                int productFirstColumn = multiDimesionalArray[0, 0] * multiDimesionalArray[1, 0];

                Console.WriteLine("Исходная матрица:");

                for (int rows = 0; rows < multiDimesionalArray.GetLength(0); rows++)
                {
                    for (int columns = 0; columns < multiDimesionalArray.GetLength(1); columns++)
                    {
                        Console.Write(multiDimesionalArray[rows, columns] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Сумма второй строки: " + sumSecondRow);
                Console.WriteLine("Произведение первого столбца: " + productFirstColumn);
            }
        }
    }
}
