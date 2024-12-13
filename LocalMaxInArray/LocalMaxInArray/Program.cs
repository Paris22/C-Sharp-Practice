using System;

namespace LocalMaxInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength;
            Random random = new Random();
            int randomLimit = 10;

            Console.Write("Введите длину массива: ");
            arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            int lastIndex = array.Length - 1;

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

            for (int index = 1; index < lastIndex; index++)
            {
                if (array[index] > array[index - 1] && array[index] > array[index + 1])
                {
                    Console.Write(array[index]);
                }
            }

            if (array.Length > 1 && array[lastIndex] > array[lastIndex - 1])
            {
                Console.Write(array[lastIndex]);
            }
        }
    }
}
