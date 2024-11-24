using System;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInputName;
            string userInputBorderChar;

            string nameLine;
            string borderLine = "";

            Console.WriteLine("Введите свое имя!");
            userInputName = Console.ReadLine();
            Console.WriteLine("Введите символ, из которого будет сделан прямоугольник вокруг имени!");
            userInputBorderChar = Console.ReadLine();

            nameLine = $"{userInputBorderChar}{userInputName}{userInputBorderChar}";

            for (int i = 0; i < nameLine.Length; i++)
            {
                borderLine += userInputBorderChar;
            }

            Console.WriteLine(borderLine);
            Console.WriteLine(nameLine);
            Console.WriteLine(borderLine);
        }
    }
}
