using System;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMessage;
            int messageRepeatNumber;

            Console.Write("Введите сообщение, которое хотите вывести повторно ");
            inputMessage = Console.ReadLine();
            Console.Write("Введите количество повторений вашего сообщения ");
            messageRepeatNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < messageRepeatNumber; i++) {
                Console.WriteLine(inputMessage);
            }
        }
    }
}
