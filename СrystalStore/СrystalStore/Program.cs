using System;

namespace СrystalStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float goldAmount;
            float crystalAmount = 0;
            int crystalPrice = 30;
            float maxCrystalsForGold;


            Console.WriteLine("Приветствуем Вас в Магазине Кристаллов!");
            Console.Write("Сколько у вас золота? ");
            goldAmount = Convert.ToSingle(Console.ReadLine());

            maxCrystalsForGold = goldAmount / crystalPrice;
            Console.WriteLine($"Цена 1 кристалла - {crystalPrice}. Максимум кристаллов доступно для покупки - {maxCrystalsForGold}");
            Console.Write("Сколько хотите приобрести? ");

            crystalAmount = Convert.ToSingle(Console.ReadLine());
            goldAmount -= crystalAmount * crystalPrice;

            Console.WriteLine($"Кол-во золота: {goldAmount}. Кол-во кристаллов: {crystalAmount}");
        }
    }
}
