using System;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int N = random.Next(10, 26);

            int multipleCount = 0;
            int numberRangeStart = 50;
            int numberRangeEnd = 150;

            Console.WriteLine($"Сгенерированное число N: {N}");

            for (int multiple = 0; multiple <= numberRangeEnd; multiple += N)
            {

                if (multiple >= numberRangeStart)
                {
                    multipleCount++;
                }

            }

            Console.WriteLine($"Количество чисел от 50 до 150, кратных {N}: {multipleCount}");
        }
    }
}
