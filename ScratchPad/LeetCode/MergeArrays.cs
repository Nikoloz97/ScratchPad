using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.LeetCode
{
    public class MergeArrays
    {
        public int[][] MergeArraysFunction(int[][] nums1, int[][] nums2)
        {
            List<int[]> mergedList = nums1.ToList<int[]>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums1[i][0] == nums2[i][0])
                {
                    mergedList[i][1] += nums2[i][1];
                }

                else if (nums1[i][0] > nums2[i][0])
                {
                    while (nums1[i][0] > nums2[i][0])
                    {
                        int j = i;
                        j++;
                        if (nums1[i][0] == nums2[j][0])
                        {
                            mergedList[i][1] += nums2[i][1];
                        }
                    }
                }

                else
                {
                    mergedList.Add(nums2[i]);
                }

            }

            return mergedList.ToArray();
        }
    }
}
