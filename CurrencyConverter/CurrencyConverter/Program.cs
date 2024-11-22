using System;

namespace CurrencyConverter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string CommandConvertRubToDol = "1";
            const string CommandConvertRubToEuro = "2";
            const string CommandConvertDolToRub = "3";
            const string CommandConvertEuroToRub = "4";
            const string CommandConvertDolToEuro = "5";
            const string CommandConvertEuroToDol = "6";
            const string CommandConsoleExit = "7";

            float userRubles;
            float userDollars;
            float userEuros;
            bool isConsoleWork = true;
            string userInput;
            float requestedCurrency;

            float rubToDolExchangeRate = 100;
            float rubToEuroExchangeRate = 106;
            float dolToEuroExchangeRate = 1.06f;
            float dolToRubExchangeRate = 0.011f;
            float euroToRubExchangeRate = 0.01f;
            float euroToDolExchangeRate = 0.95f;
            string oneCurrency = "1";

            Console.WriteLine("Добро пожаловать в конвертер валют! Введите количество каждой валюты на Вашем балансе...");
            Console.Write("Сколько рублей у Вас на балансе? ");
            userRubles = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько долларов у Вас на балансе? ");
            userDollars = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько евро у Вас на балансе? ");
            userEuros = Convert.ToSingle(Console.ReadLine());

            while (isConsoleWork)
            {
                Console.WriteLine($"Ваш баланс: {userRubles} рублей, {userDollars} долларов, {userEuros} евро");

                Console.WriteLine("Выберите команду и введите число, соответствующее консольной команде");
                Console.WriteLine($"{CommandConvertRubToDol} - Обменять рубли на доллары");
                Console.WriteLine($"{CommandConvertRubToEuro} - Обменять рубли на евро");
                Console.WriteLine($"{CommandConvertDolToRub} - Обменять доллары на рубли");
                Console.WriteLine($"{CommandConvertEuroToRub} - Обменять евро на рубли");
                Console.WriteLine($"{CommandConvertDolToEuro} - Обменять доллары на евро");
                Console.WriteLine($"{CommandConvertEuroToDol} - Обменять евро на доллары");
                Console.WriteLine($"{CommandConsoleExit} - Выйти из консоли");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandConvertRubToDol:
                        Console.WriteLine($"Сколько рублей хотите обменять? Курс {rubToDolExchangeRate} рублей - {oneCurrency} доллар");
                        requestedCurrency = Convert.ToSingle(Console.ReadLine());

                        if (userRubles >= requestedCurrency)
                        {
                            userRubles -= requestedCurrency;
                            userDollars += requestedCurrency / rubToDolExchangeRate;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно рублей!");
                        }

                        break;

                    case CommandConvertRubToEuro:
                        Console.WriteLine($"Сколько рублей хотите обменять? Курс {rubToEuroExchangeRate} рублей - {oneCurrency} евро");
                        requestedCurrency = Convert.ToSingle(Console.ReadLine());

                        if (userRubles >= requestedCurrency)
                        {
                            userRubles -= requestedCurrency;
                            userEuros += requestedCurrency / rubToEuroExchangeRate;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно рублей!");
                        }

                        break;

                    case CommandConvertDolToRub:
                        Console.WriteLine($"Сколько долларов хотите обменять? Курс {dolToRubExchangeRate} долларов - {oneCurrency} рубль");
                        requestedCurrency = Convert.ToSingle(Console.ReadLine());

                        if (userDollars >= requestedCurrency)
                        {
                            userDollars -= requestedCurrency;
                            userRubles += requestedCurrency / dolToRubExchangeRate;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно долларов!");
                        }

                        break;

                    case CommandConvertEuroToRub:
                        Console.WriteLine($"Сколько евро хотите обменять? Курс {euroToRubExchangeRate} евро - {oneCurrency} рубль");
                        requestedCurrency = Convert.ToSingle(Console.ReadLine());

                        if (userEuros >= requestedCurrency)
                        {
                            userEuros -= requestedCurrency;
                            userRubles += requestedCurrency / euroToRubExchangeRate;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно евро!");
                        }

                        break;

                    case CommandConvertDolToEuro:
                        Console.WriteLine($"Сколько долларов хотите обменять? Курс {dolToEuroExchangeRate} долларов - {oneCurrency} евро");
                        requestedCurrency = Convert.ToSingle(Console.ReadLine());

                        if (userDollars >= requestedCurrency)
                        {
                            userDollars -= requestedCurrency;
                            userEuros += requestedCurrency / dolToEuroExchangeRate;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно долларов!");
                        }

                        break;

                    case CommandConvertEuroToDol:
                        Console.WriteLine($"Сколько евро хотите обменять? Курс {euroToDolExchangeRate} евро - {oneCurrency} доллар");
                        requestedCurrency = Convert.ToSingle(Console.ReadLine());

                        if (userEuros >= requestedCurrency)
                        {
                            userEuros -= requestedCurrency;
                            userDollars += requestedCurrency / euroToDolExchangeRate;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно евро!");
                        }

                        break;

                    case CommandConsoleExit:
                        isConsoleWork = false;
                        break;
                }

            }
        }
    }
}
