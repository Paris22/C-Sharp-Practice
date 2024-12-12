using System;

namespace LocalMaxInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int[] initArray = new int[arrayLength];
            int initArrayLength = initArray.Length;

            Random random = new Random();
            int randomLimit = 10;

            Console.Write("Исходный массив: ");
            for (int index = 0; index < initArray.Length; index++)
            {
                initArray[index] = random.Next(randomLimit);
                Console.Write(initArray[index]);
            }

            Console.Write("\nЛокальные максимумы: ");
            if (initArrayLength > 1 && initArray[0] > initArray[1])
            {
                Console.Write(initArray[0]);
            }

            for (int index = 1; index < initArrayLength - 1; index++)
            {
                if (initArray[index] > initArray[index - 1] && initArray[index] > initArray[index + 1])
                {
                    Console.Write(initArray[index]);
                }
            }

            if (initArrayLength > 1 && initArray[initArrayLength - 1] > initArray[initArrayLength - 2])
            {
                Console.Write(initArray[initArrayLength - 1]);
            }
        }
    }
}
