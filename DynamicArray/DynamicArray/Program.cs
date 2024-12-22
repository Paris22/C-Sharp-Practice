using System;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSumNumbers = "sum";
            const string CommandExitConsole = "exit";

            bool isConsoleMenuWork = true;

            int[] array = new int[0];
            int[] storeArray;
            int sumNumbers = 0;

            while (isConsoleMenuWork)
            {
                Console.Write("Текущий массив: ");

                foreach (int number in array)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();

                Console.Write("Введите число или команду (sum для суммы, exit для выхода): ");
                string userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case CommandSumNumbers:
                        Console.WriteLine($"Сумма массива: {sumNumbers}");
                        break;

                    case CommandExitConsole:
                        isConsoleMenuWork = false;
                        break;

                    default:
                        if (int.TryParse(userInput, out int number))
                        {
                            storeArray = new int[array.Length + 1];

                            for (int i = 0; i < array.Length; i++)
                            {
                                storeArray[i] = array[i];
                            }

                            storeArray[storeArray.Length - 1] = number;

                            array = storeArray;

                            sumNumbers += number;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число или команду.");
                        }

                        break;
                }
            }
        }
    }
}