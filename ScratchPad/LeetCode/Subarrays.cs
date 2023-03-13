using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    //https://leetcode.com/problems/number-of-subarrays-with-bounded-maximum/
    public class Subarrays
    {
        public int SubarraysFunction(int[] nums, int left, int right) {

            List<List<int>> subLists = new List<List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                List<int> subList = new List<int>();
                int sumChecker = nums[i];

                for (int j = i; j < nums.Length; j++)
                {
                    if (j > i)
                    {
                        sumChecker += nums[j];
                    }
                    if (sumChecker >= left && sumChecker <= right)
                    {
                        
                        subList.Add(nums[j]);
                    }
                    else {
                        if (j > i)
                        {
                            sumChecker -= nums[j];
                        }
                        
                        continue; }

                    List<int> subListToAdd = new List<int>();

                    foreach (var item in subList)
                    {
                        subListToAdd.Add(item);

                    }
                    subLists.Add(subListToAdd);

                }

            }
            return subLists.Count;
        }
    }
}
