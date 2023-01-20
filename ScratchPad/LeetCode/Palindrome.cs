using System;
using System.Collections.Generic;
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
    }
}
