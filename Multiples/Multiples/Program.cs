﻿using System;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int N = random.Next(10, 26);
            Console.WriteLine($"Сгенерированное число N: {N}");

            int count = 0;
            for (int i = 50; i <= 150; i++)
            {

                if (IsMultiple(i, N))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество чисел от 50 до 150, кратных {N}: {count}");
        }

        static bool IsMultiple(int number, int divisor)
        {

            int current = divisor;
            while (current <= number)
            {
                if (current == number)
                {
                    return true;
                }
                current += divisor;
            }
            return false;
        }
    }
}