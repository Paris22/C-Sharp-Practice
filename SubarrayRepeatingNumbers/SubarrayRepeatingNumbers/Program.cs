using System;

namespace SubarrayRepeatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30] {
            5, 5, 5, 3, 3, 3, 3, 7, 8, 8,
            2, 2, 2, 2, 2, 2, 2, 1, 1, 9,
            4, 4, 4, 4, 6, 6, 9, 9, 9, 9
            };
            int maxRepeatingNumber = array[0];
            int maxCountOfRepeat = 1;
            int currentRepeatingNumber = array[0];
            int currentCountOfRepeat = 1;

            Console.Write("Исходный массив: { ");
            Console.Write(string.Join(", ", array));
            Console.WriteLine(" }");

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentCountOfRepeat++;
                }
                else
                {
                    if (currentCountOfRepeat > maxCountOfRepeat)
                    {
                        maxCountOfRepeat = currentCountOfRepeat;
                        maxRepeatingNumber = currentRepeatingNumber;
                    }
                    currentRepeatingNumber = array[i];
                    currentCountOfRepeat = 1;
                }
            }

            Console.WriteLine($"Число {maxRepeatingNumber} повторяется {maxCountOfRepeat} раз(а) подряд.");
        }
    }
}
