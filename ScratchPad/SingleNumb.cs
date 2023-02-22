using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad
{
    //https://leetcode.com/problems/single-number/
    public class SingleNumb
    {
        public int SingleNumber(int[] nums)
        {
            // Loop through each item. If there's two of it, add to skipList
            // If skipList.Contains(item), skip


            // nums = 4,1,2,1,2

            List<int> skipList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (skipList.Contains(nums[i]))
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        skipList.Add(nums[i]);
                    }
                }
                if (skipList.Count == 0)
                {
                    return nums[i];
                }
                else if (skipList[skipList.Count - 1] != nums[i])
                {
                    return nums[i];
                }

            }
            return 0;


        }
    }
}
