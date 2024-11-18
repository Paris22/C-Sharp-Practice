using System;

namespace NumbersSumWithCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numbersSum = 0;
            int number = rand.Next(100);

            for (int i = 0; i <= number; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    numbersSum += i;
                }
            }

            Console.WriteLine($"Сумма всех положительных чисел меньше или равных {number}, которые кратны 3 или 5 - {numbersSum}");
        }
    }
}
