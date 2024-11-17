using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guessedNumber;
            int lowerRangeBorder, higherRangeBorder;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            guessedNumber = rand.Next(0, 101);
            lowerRangeBorder = rand.Next(guessedNumber - 10, guessedNumber);
            higherRangeBorder = rand.Next(guessedNumber + 1, guessedNumber + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lowerRangeBorder}, но меньше чем {higherRangeBorder}");
            Console.WriteLine($"Что это за число? У вас {triesCount} попыток отгадать");

            while (triesCount-- > 0)
            {
                Console.Write("Ваш ответ: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == guessedNumber)
                {
                    Console.WriteLine("Поздравляю, вы отгадали число!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно, попробуй еще раз!");
                    Console.WriteLine($"Осталось попыток {triesCount}");
                }
            }
            if (triesCount < 0)
            {
                Console.WriteLine($"Вы проиграли. Загаданное число - {guessedNumber}");
            }

        }
    }
}
