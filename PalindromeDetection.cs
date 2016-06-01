using System;
using System.Collections.Generic;
using System.Linq;

namespace DTHW
{
    class PalindromeDetection
    {
        private string InputString { get; set; }
        private string TestString { get; set; }
        private bool IsValidPalindrome { get; set; }

        private Dictionary<char, int> CharCount;

        public bool IsPalindrome(string inputString)
        {
            IsValidPalindrome = false;
            InputString = inputString;
            RemoveNonLetterChars();
            CountCharsInString();

            // in any palindrome there can only be one letter with an odd cardinality
            if (CharCount.Where(x => x.Value % 2 != 0).Count() <= 1)
            {
                IsValidPalindrome = CompareLetters();
            }

            return IsValidPalindrome;
        }

        public void PrintResults()
        {
            Console.WriteLine(string.Format("isPalindrome = {0}\t--> '{1}'", IsValidPalindrome, InputString));
        }

        private void RemoveNonLetterChars()
        {
            var charArray = InputString.ToLower().Trim().ToCharArray();
            charArray = Array.FindAll(charArray, c => char.IsLetter(c));
            TestString = new string(charArray);
        }

        private void CountCharsInString()
        {
            CharCount = new Dictionary<char, int>();

            foreach (var character in TestString.Trim().ToCharArray())
            {
                if (CharCount.ContainsKey(character))
                {
                    CharCount[character]++;
                }
                else
                {
                    CharCount.Add(character, 1);
                }
            }
        }

        private bool CompareLetters()
        {
            var isPalindrome = true;
            var charArray = TestString.ToCharArray();
            var front = 0;
            var back = charArray.Length - 1;

            while (front < back)
            {
                if (charArray[front] == charArray[back])
                {
                    front++;
                    back--;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
