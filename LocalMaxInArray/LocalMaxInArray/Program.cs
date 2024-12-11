using System;

namespace LocalMaxInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int[] initArray = new int[arrayLength];
            int[] localMaxArray;

            Random random = new Random();

            for (int index = 0; index < initArray.Length; index++)
            {
                initArray[index] = random.Next();
            }

            for (int index = 0; index < initArray.Length; index++)
            {
                if (initArray[index] > initArray[index - 1] && initArray[index] > initArray[index + 1])
                {

                }
            }
        }
    }
}
