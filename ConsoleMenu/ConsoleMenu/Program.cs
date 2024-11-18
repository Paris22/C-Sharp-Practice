using System;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandShowWelcomeText = "1";
            const string CommandShowApprovalText = "2";
            const string CommandShowRandomNumber = "3";
            const string CommandClearConsole = "4";
            const string CommandExitConsole = "5";

            bool isConsoleMenuWork = true;
            Random random = new Random();
            string userInput; 

            while (isConsoleMenuWork)
            {
                Console.WriteLine("Приветствуем тебя в консольном меню! Введите число для выбора команды!");
                Console.WriteLine($"{CommandShowWelcomeText} - Показать приветственный текст");
                Console.WriteLine($"{CommandShowApprovalText} - Показать похвальный текст");
                Console.WriteLine($"{CommandShowRandomNumber} - Показать случайное число");
                Console.WriteLine($"{CommandClearConsole} - Очистить консоль");
                Console.WriteLine($"{CommandExitConsole} - Выйти из консольного меню");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandShowWelcomeText:
                        Console.WriteLine("Привет, дорогой друг!");
                        break;

                    case CommandShowApprovalText:
                        Console.WriteLine("Ты молодец! Продолжай в том же духе!");
                        break;

                    case CommandShowRandomNumber:
                        Console.WriteLine(random.Next());
                        break;

                    case CommandClearConsole:
                        Console.Clear();
                        break;

                    case CommandExitConsole:
                        isConsoleMenuWork = false;
                        break;

                    default: 
                        Console.WriteLine("Такой команды нет... Введите другую!");
                        break;
                }
            }
        }
    }
}
