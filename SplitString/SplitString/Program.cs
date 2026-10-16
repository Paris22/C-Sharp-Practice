using System;

namespace SplitString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = "Какой-то текст с пробелами";

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
