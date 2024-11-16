using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroName;
            int heroHeight;
            float heroWeight;

            Console.WriteLine("Заполните информацию про своего персонажа!");
            Console.Write("Введите имя персонажа: ");
            heroName = Console.ReadLine();
            Console.Write("Рост персонажа: ");
            heroHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вес персонажа: ");
            heroWeight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Вашего персонажа зовут {heroName}, его рост - {heroHeight}, а вес - {heroWeight}");
        }
    }
}
