using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    internal class MaxArea
    {
        // https://leetcode.com/problems/container-with-most-water/

        public int GetMaxArea(int[] bars)
        {
            // Create height (h) and width (w) variables
            // Create currentMaxArea (m)
            // For each item in array (i)
            // Loop through whole array (besides itself; j)
            // Lesser of two values = h (or if equal, just choose first one)
            // |i - j| = w
            // h x w = m 


            int height = 0;
            int width = 0;
            int currentArea = 0;
            int currentMaxArea = 0;

            for (int i = 0; i < bars.Length; i++)
            {
                for (int j = 0; j < bars.Length; j++)
                {
                    if (i == j) { continue; }

                    else if (bars[j] == bars[i]) { height = bars[j]; }

                    else { height = Math.Min(bars[j], bars[i]); }

                    width = Math.Abs(i - j);

                    currentArea = height * width;

                    if (currentArea > currentMaxArea)
                    {
                        currentMaxArea = currentArea;

                    }

                }

            }

            return currentMaxArea;



        }
    }
}
