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
            // Create counter
            // Given one can always do one step at a time, start at 1
            int waysCounter = 1;

            // Initialize twoStepPossibilities where it can substitute a one-step spot
            int twoStepPoss = steps;

            bool firstIteration = true;

            while (steps >= 2)
            {
               
                steps -= 2;

                //in every iteration following first, as "one-steps" are combined into a two-step, twoStepPoss is reduced by two

                if (!firstIteration)
                {
                    twoStepPoss -= 2;
                    waysCounter += twoStepPoss;

                }
                else
                {
                    twoStepPoss--;
                    waysCounter += twoStepPoss;
                }

                //set first iteration to false
                firstIteration = false;
               

            }

            return waysCounter;


        }

    }
}
