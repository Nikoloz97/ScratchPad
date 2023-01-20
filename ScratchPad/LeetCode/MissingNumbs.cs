using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.LeetCode
{
    public class MissingNumbs
    {
       
        public int FindMissingNumber(int[] nums)
        {
            // Initialize max val
            int maxValue = nums[0];

            

            // find max values in array 
            for (int i = 0; i < nums.Length; i++)
            {
                if (maxValue < nums[i])
                {
                    maxValue = nums[i];
                }
            }


            // Pass in values to FullArray function
            int[] fullArray = FullArray(maxValue);


            // for each value in fullArray... 
            for (int i = 0; i < fullArray.Length; i++)
            {
          
                for (int j = 0; j < nums.Length; j++)
                {
                    // If it matches with a value in num array, break out of foreach (iterate to next item in fullArray);
                    if (fullArray[i] == nums[j])
                    { 
                        break;
                    }

                    // else, if were at the last item of the nums array, and we still don't have a match, return that full array value
                    else if (j == nums.Length - 1 && fullArray[i] != nums[j])
                    {
                        return fullArray[i];
                    }
                    
                }
            }



            // If nothing is missing, return max + 1 

            return maxValue + 1;


/*
            // (Cheat - using Linq...)
            int maxNumb = nums.Max();
            int minNumb = nums.Min();
*/

        }


        public int[] FullArray(int maxVal)
        {
            // Initialize array 
            int[] fullArray = new int[maxVal + 1];


            // Load array with values
            for (int i = 0; i <= maxVal; i++)
            {
                fullArray[i] = i;
            }

            // Return  array
            return fullArray;


        }
    }
}
