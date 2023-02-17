using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    // https://leetcode.com/problems/isomorphic-strings/
    public class Isomorphic
    {
        public bool IsIsomorphic(string s, string t)
        {
            // s = "paper"
            // t = "title"

            List<int> sIndexList = new List<int>();
            List<int> tIndexList = new List<int>();

            int counter = 0;

            while (counter < s.Length)
            {
                for (int i = counter + 1; i < s.Length; i++)
                {
                    if (s[i] == s[counter])
                    {
                        sIndexList.Add(i);
                    }

                    if (t[i] == t[counter])
                    {
                        tIndexList.Add(i);
                    }

                    if (tIndexList.Count != sIndexList.Count)
                    {
                        return false;
                    }

                    for (int j = 0; j < sIndexList.Count; j++)
                    {
                        if (sIndexList[j] != tIndexList[j])
                        {
                            return false;

                        }
                    }
                }
                counter++;
            }

            return true; 
        }
    }
}
