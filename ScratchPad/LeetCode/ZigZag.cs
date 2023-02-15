using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    // Link: https://leetcode.com/problems/zigzag-conversion/
    public class ZigZag
    {
        public string Convert (string s, int numRows)
        {


            // Indexes pattern:

            // numRows 2
            // row1 = 0, 2, 4, 6, 8, 10, 12
            // row2 = 1, 3, 5, 7, 9, 11, 13

            // numRows 3
            // row1 = 0, 4, 8, 12
            // row2 = 1, 3, 5, 7, 9, 11, 13
            // row3 = 2, 6, 10, 

            // numRows 4
            // row1 = 0, 6, 12
            // row2 = 1, 5, 7, 11, 13
            // row3 = 2, 4, 8, 10
            // row4 = 3, 9, 

            // Pattern:
            // First indexes for each row = increment index as you go down
            // After then...
            // Odd indexes for each row = skip index of last row, increment index as you go up
            // Even indexes for each row = skip index of first row, increment index as you go down





        }

    }
}
