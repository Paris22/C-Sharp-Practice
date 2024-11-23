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

            int borderWidth = userInputName.Length + 2;

            for (int i = 0; i < borderWidth; i++)
            {
                borderLine += userInputBorderChar;
            }

            nameLine = $"{userInputBorderChar}{userInputName}{userInputBorderChar}";

            Console.WriteLine(borderLine);
            Console.WriteLine(nameLine);
            Console.WriteLine(borderLine);
        }
    }
}
