using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.LeetCode
{
    // https://leetcode.com/problems/move-zeroes/
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            List<int> numsList = nums.ToList();

            foreach (int num in nums)
            {
                if (num == 0)
                {
                    numsList.Remove(num);
                    numsList.Add(0);
                }

            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = numsList[i];
            }
        }


    }
}
