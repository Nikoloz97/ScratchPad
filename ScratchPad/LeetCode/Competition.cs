using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    // https://leetcode.com/problems/minimum-hours-of-training-to-win-a-competition/
    public class Competition
    {
        public int MinNumOfHours (int initialEnergy, int initialExperience, int[] energy, int[] experience )
        {
            int trainingHours = 0;
  
            // While opponent <= energy.Length - 1
            // for item in energy array
            // If energy[i] and experience[i] is greater than iEn and iEx, increase experience and decrease energy
            // Else, while energy is less and experience is less...
            // If energy is less, increment tH, iEn by 1;  else-if experience is low, increment tH, iEx by 1
            int currentEnergy = initialEnergy;
            int currentExperience = initialExperience;

            
                
                for (int i = 0; i <= energy.Length - 1; i++)
                {
            
                    if (energy[i] < currentEnergy && experience[i] < currentExperience)
                    {
                        currentExperience += experience[i];
                        currentEnergy -= energy[i];
                    }
                    else
                    {
                        while (energy[i] >= currentEnergy || experience[i] >= currentExperience)
                        {
                            trainingHours++;

                            if (energy[i] >= currentEnergy) { currentEnergy++; }

                            else { currentExperience++; }
                        }
                        currentExperience += experience[i];
                        currentEnergy -= energy[i];
                }
                }

            return trainingHours;

        }
    }
}
