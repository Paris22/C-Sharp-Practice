using System;

namespace PolyclinicQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personsNumber;
            int timePerPerson = 10;

            int hoursInQueue;
            int minutesInQueue;

            int minutesToHoursConverter = 60;

            Console.Write("Вы приходите в поликлинику и видите очередь... Кол-во людей в очереди: ");
            personsNumber = Convert.ToInt32(Console.ReadLine());

            hoursInQueue = personsNumber * timePerPerson / minutesToHoursConverter;
            minutesInQueue = personsNumber * timePerPerson % minutesToHoursConverter;

            Console.WriteLine($"Время, которое Вам нужно отстоять в очереди: кол-во часов - {hoursInQueue}, кол-во минут - {minutesInQueue}");
        }
    }
}
