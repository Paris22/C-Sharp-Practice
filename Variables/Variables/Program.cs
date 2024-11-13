using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroName;
            int heroHeight;
            float heroWeight;

            double heroHealth = 100;
            byte heroItemsNumber = 5;
            float heroItemMagicResistance = 7;
            bool isHeroAlive = true;
            float heroMagicResistance;

            float fireballDamage = 10;
            short fireballsNumber = 5;
            float allFireballsDamage;
            
            int percentConverter = 100;

            Console.WriteLine("Заполните информацию про своего персонажа!");
            Console.Write("Введите имя персонажа: ");
            heroName = Console.ReadLine();
            Console.Write("Рост персонажа: ");
            heroHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вес персонажа: ");
            heroWeight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Вдруг вы видите перед собой {fireballsNumber} огненных шаров, летящих в вас!");

            heroMagicResistance = heroItemMagicResistance * heroItemsNumber;
            allFireballsDamage = fireballDamage * fireballsNumber;

            heroHealth -= allFireballsDamage * heroItemMagicResistance / percentConverter;
            isHeroAlive = heroHealth > 0;

            Console.WriteLine($"Ваше оставшееся здоровье: {heroHealth}");
        }
    }
}
