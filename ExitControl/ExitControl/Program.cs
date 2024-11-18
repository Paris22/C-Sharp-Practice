using System;

namespace ExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInputMessage;
            string exitText = "exit";

            string enterMessageText = $"Введите сообщение. Если не хотите больше вводить сообщение, то введите {exitText}";

            Console.WriteLine(enterMessageText);
            userInputMessage = Console.ReadLine();

            while (userInputMessage != exitText)
            {
                Console.WriteLine(enterMessageText);
                userInputMessage = Console.ReadLine();
            }
        }
    }
}
