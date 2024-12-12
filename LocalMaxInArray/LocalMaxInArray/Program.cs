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

            for (int index = 0; index < initArray.Length; index++)
            {
                initArray[index] = random.Next();
            }

            if (initArrayLength > 1 && initArray[0] > initArray[1])
            {
                Console.WriteLine(initArray[0]);
            }

            for (int index = 0; index < initArrayLength; index++)
            {
                if (initArray[index] > initArray[index - 1] && initArray[index] > initArray[index + 1])
                {
                    Console.WriteLine(initArray[index]);
                }
            }

            if (initArrayLength > 1 && initArray[initArrayLength - 1] > initArray[initArrayLength - 2])
            {
                Console.WriteLine(initArray[initArrayLength - 1]);
            }
        }
    }
}
