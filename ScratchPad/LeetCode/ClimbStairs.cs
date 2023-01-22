using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    public class ClimbStairs
    {
        /// <summary>
        /// Given the number of steps as a parameter (constraints: 1-45 inclusive), determines ways that one can reach to that value, 
        /// given one can take one or two steps at a time
        /// </summary>
        /// <param name="steps"></param>
        /// <returns> Number of steps</returns>
        public int NumberOfWays(int steps)
        {
            int first = 1;
            int second = 1;
            while (steps-- > 0)
            {
                int tmp = first;
                first = second;
                second = tmp + second;
            }

            return first;


        }

    }
}
