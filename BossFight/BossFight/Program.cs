using System;

namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandHeroBaseAttack = "1";
            const string CommandHeroFireball = "2";
            const string CommandHeroFireballExplosion = "3";
            const string CommandHeroHeal = "4";

            int bossHealth = 100;
            int bossAttack = 15;

            int heroHealth = 75;
            int heroMana = 100;
            int heroBaseAttackDamage = 10;
            int heroFireballDamage = 25;
            int heroFireballManaCost = 45;
            int heroFireballExplosionDamage = 35;
            bool isFireballUsed = false;
            int heroHealPoints = 25;
            int maxHeroHealUse = 3;

            string userInput;

            Console.WriteLine($"Здоровье босса - {bossHealth}, наносимый боссом урон - {bossAttack}");
            Console.WriteLine($"Здоровье героя - {heroHealth}, мана героя - {heroMana}");


            while (bossHealth > 0 && heroHealth > 0)
            {

                Console.WriteLine("Что будете делать в битве с боссом?");
                Console.WriteLine($"{CommandHeroBaseAttack} - Ударить обычной атакой");
                Console.WriteLine($"{CommandHeroFireball} - Применить огненный шар. Требует {heroFireballManaCost} маны");
                Console.WriteLine($"{CommandHeroFireballExplosion} - Применить взрыв от огненного шара. Для активации требуется заранее применить огненный шар");
                Console.WriteLine($"{CommandHeroHeal} - Восстанавливает {heroHealPoints} здоровья и маны. Оставшихся возможных применений: {maxHeroHealUse}");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandHeroBaseAttack:
                        bossHealth -= heroBaseAttackDamage;
                        break;

                    case CommandHeroFireball:
                        if (heroMana >= heroFireballManaCost)
                        {
                            bossHealth -= heroFireballDamage;
                            heroMana -= heroFireballManaCost;
                            isFireballUsed = true;
                        }

                        break;

                    case CommandHeroFireballExplosion:
                        if (isFireballUsed)
                        {
                            bossHealth -= heroFireballExplosionDamage;
                            isFireballUsed = false;
                        }

                        break;
                }

            }
        }
    }
}
