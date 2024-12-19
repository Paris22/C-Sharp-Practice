using System;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSumNumbers = "Сумма";
            const string CommandExitConsole = "Выход";

            bool isConsoleMenuWork = true;

            Random random = new Random();
            string userInput;
            string inputNumbers;

            int[] array = new int[1];
            int[] extendArray = new int[array.Length + 1];
            int sumNumbers = 0;

            userInput = Console.ReadLine();

            while (isConsoleMenuWork)
            {

                Console.Write("Текущий массив: ");
                foreach (int number in array)
                {
                    Console.Write(number);
                }

                switch (userInput)
                {
                    case CommandSumNumbers:
                        Console.WriteLine($"Сумма массива: {sumNumbers}");
                        break;
                    case CommandExitConsole:
                        isConsoleMenuWork = false;
                        break;

                    default:
                        array[array.Length - 1] = Convert.ToInt32(userInput);
                        break;
                }
            }
        }
    }
}
