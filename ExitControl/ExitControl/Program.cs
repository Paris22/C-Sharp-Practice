using System;

namespace ExitControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMessage;

            Console.WriteLine("Введите сообщение. Если не хотите больше вводить сообщение, то введите 'exit'");
            inputMessage = Console.ReadLine();

            while (inputMessage != "exit")
            {
                Console.WriteLine("Введите сообщение. Если не хотите больше вводить сообщение, то введите 'exit'");
            }
        }
    }
}
