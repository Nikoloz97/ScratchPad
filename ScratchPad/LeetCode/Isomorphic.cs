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
            // Create s index (int) list 
            // Create t index (int) list


            //Loop through s (i), starting from counter + 1
            // if s(i) = s(counter), add i to s-list

            //Loop through t (i), starting from counter + 1
            // if t(i) = t(counter), add i to t-list

            //Loop through s-array (i)
            // If s-list(i) != t-list (i), isomorphicChecker == false

            // Counter++ 

            bool isomorphicChecker = true;

            int counter = 0;

            List<int> sIndexList = new List<int>();
            List<int> tIndexList = new List<int>();

            while (isomorphicChecker && counter < s.Length)
            {
                for (int i = counter; i < s.Length; i++)
                {
                    if (s[i] == s[counter])
                    {
                        sIndexList.Add(i);
                    }

                }

                for (int i = counter; i < t.Length; i++)
                {
                    if (t[i] == t[counter])
                    {
                        tIndexList.Add(i);
                    }

                }

                if (tIndexList.Count != sIndexList.Count)
                {
                    isomorphicChecker = false;
                    return isomorphicChecker;
                }

                for (int j = 0; j < sIndexList.Count; j++)
                {
                    if (sIndexList[j] != tIndexList[j])
                    {
                        isomorphicChecker = false;
                        return isomorphicChecker;

                    }

                }

                counter++;
            }

            return isomorphicChecker; 
        }
    }
}
