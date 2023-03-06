using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    // https://leetcode.com/problems/watering-plants/
    public class Plants
    {
        public int WateringPlants(int[] plants, int capacity)
        {
            int stepsCounter = 0;
            int canStatus = capacity;

            for (int i = 0; i < plants.Length; i++)
            {
                if (canStatus >= plants[i])
                {
                    stepsCounter++;
                    canStatus -= plants[i]; 
                }
                else
                {
                    stepsCounter += ((i * 2) + 1);
                    canStatus = capacity;
                    canStatus -= plants[i];
                }
               
            }

            return stepsCounter;

        }

    }
}
