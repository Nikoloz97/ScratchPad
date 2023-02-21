using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    //https://leetcode.com/problems/is-subsequence/
    public class Subsequence
    {
        // "aaaaaa", "bbaaaa"

        public bool IsSubsequence (string s, string t)
        {
            int[] indexArray = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                int index;

                if (i == 0)
                {
                    index = t.IndexOf(s[i]);
                }
                else
                {
                    int startIndex = indexArray[i - 1] + 1;
                    index = t.IndexOf(s[i], startIndex);
                }
                if (index == -1 || (indexArray[i] == t.Length - 1 && i < s.Length - 1)) 
                { 
                    return false; 
                }

                indexArray[i] = index;
            }



            for (int i = 1; i < indexArray.Length; i++)
            {
                if (indexArray[i] < indexArray[i - 1])
                {
                    return false;
                }

            }

            return true;

        }
    }
}
