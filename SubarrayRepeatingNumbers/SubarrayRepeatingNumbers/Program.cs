using System;

namespace SubarrayRepeatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30] {
            5, 5, 5, 3, 3, 3, 3, 7, 8, 8,
            2, 2, 2, 2, 2, 1, 1, 9, 4, 4,
            4, 4, 6, 6, 9, 9, 9, 9, 9, 9
            };
            int maxRepeatingNumber = numbers[0];
            int maxCountOfRepeat = 1;
            int currentRepeatingNumber = numbers[0];
            int currentCountOfRepeat = 1;

            Console.Write("Исходный массив: { ");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine(" }");

            for (int i = 1; i <= numbers.Length; i++)
            {
                if (i < numbers.Length && numbers[i] == numbers[i - 1])
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

                    if (i < numbers.Length)
                    {
                        currentRepeatingNumber = numbers[i];
                        currentCountOfRepeat = 1;
                    }
                }
            }

            Console.WriteLine($"Число {maxRepeatingNumber} повторяется {maxCountOfRepeat} раз(а) подряд.");
        }
    }
}
