using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.LeetCode
{
    public class UniqueSum
    {
        public int SumOfUnique(int[] nums)
        {
            var numsList = nums.ToList();
            var sum = 0;
            for (int i = 0; i < numsList.Count; i++)
            {
                bool overOneMatch = false;

                for (int j = i+1; j < numsList.Count; j++)
                {
                    if (numsList[i] == numsList[j])
                    {
                        overOneMatch = true;
                        numsList[j] = 0;
                    }
                }
                if (overOneMatch)
                {
                    numsList[i] = 0;
                }
                sum += numsList[i];

            }

            return sum;
        }
    }
}
