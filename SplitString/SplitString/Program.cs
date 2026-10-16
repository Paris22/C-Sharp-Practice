using System;

namespace SplitString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = "Какой-то текст с пробелами";
            char splitter = ' ';

            string[] words = text.Split(splitter);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
