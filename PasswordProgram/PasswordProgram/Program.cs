using System;

namespace PasswordProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userPassword = "qwerty12345";
            string userInput;
            string secretMessage = "Секретное сообщение";

            int tryCounter;
            int maxTries = 3;

            Console.WriteLine("Введите пароль!");

            for (tryCounter = 0; tryCounter < maxTries; tryCounter++)
            {
                userInput = Console.ReadLine();

                if (userPassword == userInput)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный пароль. Ввведите пароль еще раз!");
                }

            }
        }
    }
}
