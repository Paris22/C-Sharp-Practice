using System;

namespace SortNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[30] {
            3, 2, 4, 6, 45, 3, 9, 7, 31, 8,
            7, 2, 55, 8, 2, 1, 10, 9, 21, 24,
            15, 4, 13, 6, 56, 12, 11, 60, 16, 25
            };
            int temporarySwapNumber;
            int lastIndexOfNumbers = numbers.Length - 1;

            Console.WriteLine("Изначальный массив:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            for (int i = 0; i < lastIndexOfNumbers; i++)
            {
                for (int j = 0; j < lastIndexOfNumbers - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temporarySwapNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temporarySwapNumber;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");

            }

            Console.ReadKey();
        }
    }
}
