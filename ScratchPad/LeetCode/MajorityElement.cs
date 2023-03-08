using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    // https://leetcode.com/problems/majority-element/
    public class MajorityElement
    {
        public int Majority(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 0;
                double halfwayPoint = Convert.ToDouble(nums.Length) / 2;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        counter++;
                        if (counter >= halfwayPoint)
                        {
                            return nums[i];
                        }
                    }

                }
            }
            return 0;

        }


    }
}
