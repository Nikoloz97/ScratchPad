using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.LeetCode
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            // Convert integer to string...

            String stringX = x.ToString();

            // Create reversed string... 

            String reversedX = String.Empty;

            // Fill in reversed string...

            for (int i = stringX.Length - 1; i >= 0; i--)
            {
                reversedX += stringX[i];
            }

            // Check if reversed string == forward string

            if (reversedX == stringX)
            {
                return true;
            }
            return false;

        }


        public Boolean IsPali (string possiblePalindrome)
        {
            string reversedString = string.Empty;

            for (int i = possiblePalindrome.Length - 1; i >= 0; i--)
            {
                reversedString+= possiblePalindrome[i];
            }
            if (reversedString == possiblePalindrome)
            {
                return true;
            }
            return false;
        }

        public List<string> Iterator(string s, int substringLength)
        {
            List<string> currentIteratePalindromes = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                // We want i + substring Length to always be > s.Length (otherwise index out of range)

                if (i + substringLength >= s.Length)
                {
                    substringLength = s.Length - 1;
                }

                string possiblePalindrome = s.Substring(i, substringLength);
                if (IsPali(possiblePalindrome))
                {
                    currentIteratePalindromes.Add(possiblePalindrome);
                }

            }
            return currentIteratePalindromes;
           
        }

     
        // https://leetcode.com/problems/palindrome-partitioning/
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> palindromeList = new List<IList<string>>();
            int SubstringLength = 1;

            while (SubstringLength < s.Length)
            {
                Iterator(s, SubstringLength);
                SubstringLength++;
            }
         
            return palindromeList;
        }
    }
}
