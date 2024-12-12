using System;

namespace LocalMaxInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInputArrayLength;
            Random random = new Random();
            int randomLimit = 10;

            Console.Write("Введите длину массива: ");
            userInputArrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[userInputArrayLength];

            Console.Write("Исходный массив: ");

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = random.Next(randomLimit);
                Console.Write(array[index]);
            }

            Console.Write("\nЛокальные максимумы: ");

            if (array.Length > 1 && array[0] > array[1])
            {
                Console.Write(array[0]);
            }

            for (int index = 1; index < array.Length - 1; index++)
            {
                if (array[index] > array[index - 1] && array[index] > array[index + 1])
                {
                    Console.Write(array[index]);
                }
            }

            if (array.Length > 1 && array[array.Length - 1] > array[array.Length - 2])
            {
                Console.Write(array[array.Length - 1]);
            }
        }
    }
}
