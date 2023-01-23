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
            // 5 -> theoretical = 8
            int first = 1;
            int second = 1;

            // e.g. steps = 5
            while (steps-- > 0) // start at 5, not 4 - the decrement happens AFTER the while statement is evaluated
            {
                // tmp = 1
                int tmp = first;
                // first = 1
                first = second;
                // second = 1 + 1 = 2
                second = tmp + second;
                // keep doing this - once steps = 1, first = 
            }

            return first;


        }

    }
}
