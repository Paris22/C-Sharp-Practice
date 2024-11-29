using System;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int generatedNumber = random.Next(10, 26);

            int multipleCount = 0;
            int numberRangeStart = 50;
            int numberRangeEnd = 150;

            Console.WriteLine($"Сгенерированное число N: {generatedNumber}");

            for (int multiple = 0; multiple <= numberRangeEnd; multiple += generatedNumber)
            {
                if (multiple >= numberRangeStart)
                {
                    multipleCount++;
                }
            }

            Console.WriteLine($"Количество чисел от {numberRangeStart} до {numberRangeEnd}, кратных {generatedNumber}: {multipleCount}");
        }
    }
}
