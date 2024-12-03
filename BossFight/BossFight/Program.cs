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
            int bossAttackDamage = 15;

            int currentHeroHealth = 75;
            int currentHeroMana = 100;
            int maxHeroHealth = 75;
            int maxHeroMana = 100;

            int heroBaseAttackDamage = 10;
            int heroFireballDamage = 25;
            int heroFireballManaCost = 55;
            int heroFireballExplosionDamage = 35;
            bool isFireballUsed = false;
            int heroHealPoints = 25;
            int maxHeroHealUse = 3;

            string userInput;

            while (bossHealth > 0 && currentHeroHealth > 0)
            {
                Console.WriteLine($"Здоровье босса - {bossHealth}, наносимый боссом урон - {bossAttackDamage}");
                Console.WriteLine($"Здоровье героя - {currentHeroHealth}, мана героя - {currentHeroMana}");

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
                        if (currentHeroMana >= heroFireballManaCost)
                        {
                            bossHealth -= heroFireballDamage;
                            currentHeroMana -= heroFireballManaCost;
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

                    case CommandHeroHeal:
                        if (maxHeroHealUse > 0 && (currentHeroHealth < maxHeroHealth || currentHeroMana < maxHeroMana))
                        {
                            currentHeroHealth += heroHealPoints;

                            if (currentHeroHealth > maxHeroHealth)
                            {
                                currentHeroHealth = maxHeroHealth;
                            }

                            currentHeroMana += maxHeroMana;

                            if (currentHeroMana > maxHeroMana)
                            {
                                currentHeroMana = maxHeroMana;
                            }

                            maxHeroHealUse -= 1;
                        }
                        break;

                    default:
                        Console.WriteLine("Такой команды нет... Ты пропускаешь ход...");
                        break;
                }

                Console.WriteLine($"Босс также совершает атаку и наносит тебе {bossAttackDamage} урона");
                currentHeroHealth -= bossAttackDamage;
            }

            if (currentHeroHealth <= 0 && bossHealth <= 0)
            {
                Console.WriteLine("Ничья! Босс и герой погибли...");
            }
            else if (currentHeroHealth <= 0)
            {
                Console.WriteLine("Герой побежден... Ты проиграл!");
            }
            else if (bossHealth <= 0)
            {
                Console.WriteLine("Босс побежден... Ты победил!");
            }
        }
    }
}
