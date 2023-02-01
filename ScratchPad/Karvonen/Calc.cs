using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.Karvonen
{
    // Everything involving calculations
    public class Calc
    {
        // Instantiate UI
        readonly UI ui = new UI();

        /// <summary>
        /// Generates target HR given age, restingHR, and intensity given following formula:  Target = (((220 - age) - resting) * intensity) + resting
        /// </summary>
        /// <param name="age"></param>
        /// <param name="restingHR"></param>
        /// <param name="intensity"></param>
        /// <returns></returns>
        public int GenTargetHR(int age, int restingHR, double intensity)
        {
            double TargetHR = (((220 - age) - restingHR) * intensity) + restingHR;

            // E.g. convert 125.00 -> 125
            return (int)TargetHR;
        }


        /// <summary>
        /// Generates a dictionary that consists of intensity-TargetHR pairing (key-value, respectively). Calls on GenTargetHR function
        /// </summary>
        /// <returns> Dictionary <int,int> </returns>
        public Dictionary <int, int> GenIntRateDict()
        {
            int age = ui.PromptAge();
            int restingHR = ui.PromptHR();
            double Intensity = 0.55;

            Dictionary<int, int> IntRateDict = new Dictionary<int, int>();


            for (double i = Intensity; i <= 0.95; i+=0.10)
            {
                int targetHR = GenTargetHR(age, restingHR, i);

                // E.g. convert 55.00 -> 55
                int intensityDisplay = (int)(i * 100);

                IntRateDict.Add(intensityDisplay, targetHR);
            }
            return IntRateDict;
        }
    
    }
}
