using System;

namespace StringManip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello User! Please Input a string to reverse");
            string input = Console.ReadLine();

            StringReversal reversal = new StringReversal(input);
            reversal.PerformReversal();

            Console.WriteLine(reversal.GetReversedInput());
            Console.WriteLine(reversal.IsPalindrome());
        }
    }
}
