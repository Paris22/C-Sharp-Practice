using System;

namespace VariablesSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Doe";
            string lastName = "John";

            Console.WriteLine($"До перестановки: Имя - {firstName}, Фамилия - {lastName}");

            string swapVariable = firstName;
            firstName = lastName;
            lastName = swapVariable;

            Console.WriteLine($"После перестановки: Имя - {firstName}, Фамилия - {lastName}");
        }
    }
}
