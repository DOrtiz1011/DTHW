using System;

namespace DTHW
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** Key Counts ***");

            var keyCounts = new KeyCounts("input.txt");
            keyCounts.PrintResults();

            //---------------------------------------------------------------------------

            Console.WriteLine("\n*** Palindrome Detection ***");

            var palindromeDetection = new PalindromeDetection();

            palindromeDetection.IsPalindrome("Ah, Satan sees Natasha");
            palindromeDetection.PrintResults();

            palindromeDetection.IsPalindrome("pop");
            palindromeDetection.PrintResults();

            palindromeDetection.IsPalindrome("racecar");
            palindromeDetection.PrintResults();

            palindromeDetection.IsPalindrome("DealerTrack");
            palindromeDetection.PrintResults();

            palindromeDetection.IsPalindrome("Software Engineer");
            palindromeDetection.PrintResults();

            Console.ReadLine();
        }
    }
}
