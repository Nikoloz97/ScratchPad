using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.LeetCode
{
    public static class PivotIndex
    {
        public static int FindPivotIndex(int[] nums)
        {
            int leftCounter = 0;
            int rightCounter = nums.Sum();

 
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    rightCounter -= nums[i];
                }
                else {
                    leftCounter += nums[i - 1];
                    rightCounter -= nums[i];
                }

                if (leftCounter == rightCounter)
                {
                    return i;
                }
            }
            return -1;

           


        }
    }
}
