using System;

namespace NumbersSumWithCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numbersSum = 0;
            int numberRandomLimit = 100;
            int firstMultiplicityConditionNumber = 3;
            int secondMultiplicityConditionNumber = 5;
            int number = random.Next(numberRandomLimit);

            for (int i = 0; i <= number; i++) {
                if (i % firstMultiplicityConditionNumber == 0 || i % secondMultiplicityConditionNumber == 0) {
                    numbersSum += i;
                }
            }

            Console.WriteLine($"Сумма всех положительных чисел меньше или равных {number}, которые кратны {firstMultiplicityConditionNumber} или {secondMultiplicityConditionNumber} - {numbersSum}");
        }
    }
}
