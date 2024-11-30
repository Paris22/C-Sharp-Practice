using System;

namespace DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomGeneratedNumber = random.Next(256);

            int degreeOfTwo = 0;
            int numberInDegree = 1;

            while (numberInDegree <= randomGeneratedNumber)
            {
                degreeOfTwo++;
                numberInDegree *= 2;
            }

            Console.WriteLine($"Заданное рандомом число: {randomGeneratedNumber}, число превосходящее заданное: {numberInDegree}, степень двойки превосходящего числа {degreeOfTwo}");
        }
    }
}
