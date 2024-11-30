using System;

namespace DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxRandomGeneratedNumber = 256;
            int randomGeneratedNumber = random.Next(maxRandomGeneratedNumber);

            int degreeOfNumber = 0;
            int numberInDegree = 1;
            int powerNumber = 2;

            while (numberInDegree <= randomGeneratedNumber)
            {
                degreeOfNumber++;
                numberInDegree *= powerNumber;
            }

            Console.WriteLine($"Заданное рандомом число: {randomGeneratedNumber}, число превосходящее заданное: {numberInDegree}, степень {powerNumber} превосходящего числа {degreeOfNumber}");
        }
    }
}
