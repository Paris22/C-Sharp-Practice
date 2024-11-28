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

            Console.WriteLine($"Сгенерированное число N: {N}");

            for (int rangeNumber = 50; rangeNumber <= 150; rangeNumber++)
            {
                int currentDivisor = N;

                while (currentDivisor <= rangeNumber)
                {

                    if (currentDivisor == rangeNumber)
                    {
                        multipleCount++;
                    }

                    currentDivisor += N;
                }
            }

            Console.WriteLine($"Количество чисел от 50 до 150, кратных {N}: {multipleCount}");
        }
    }
}
