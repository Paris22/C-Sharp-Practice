using System;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandInputNumbers = "1";
            const string CommandSumNumbers = "2";
            const string CommandExitConsole = "3";

            bool isConsoleMenuWork = true;

            Random random = new Random();
            string userInput;
            string inputNumbers;

            int sumNumbers = 0;

            userInput = Console.ReadLine();

            while (isConsoleMenuWork)
            {

                switch (userInput)
                {
                    case CommandInputNumbers:
                        inputNumbers = Console.ReadLine();
                        break;
                    case CommandSumNumbers:
                        break;
                    case CommandExitConsole:
                        isConsoleMenuWork = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
