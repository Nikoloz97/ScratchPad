using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    // https://leetcode.com/problems/length-of-last-word/
    public class LastWord
    {
        public int LengthOfLastWord(string s)
        {
            string[] sArray = s.Split(" ");

            for (int i = sArray.Length - 1; i >= 0; i--)
            {
                if (sArray[i] == "")
                {
                    continue;
                }

                return sArray[i].Length;

            }

            return 0;

        }

    }
}
