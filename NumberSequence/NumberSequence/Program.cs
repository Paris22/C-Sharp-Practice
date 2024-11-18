using System;

namespace NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberSequenceStart = 5;
            int numberSequenceEnd = 103;
            int numberSequenceStep = 7;

            for (int i = numberSequenceStart; i <= numberSequenceEnd; i += numberSequenceStep)
            {
                Console.WriteLine(i);
            }
        }
    }
}
