using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad
{
    /// <summary>
    /// Class <c>LeetCode</c> Involves everything to do with leetcode functions
    /// </summary>
    internal class LeetCode
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

            if (reversedX == stringX)
            {
                return true;
            }
            return false;

        }

    }
}
