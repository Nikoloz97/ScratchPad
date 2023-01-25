using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.Karvonen
{
    // This is everything involving the user interface on the console application
    // TODO: Create testing file for the calculations
    public class UI
    {
        // class attributes
        int UserAge { get; set; }
        int UserHR { get; set; }
        

        public static void WelcomeScreen()
        {
            Console.WriteLine("Welcome to the Karvonean Heart Rate Calculator!");

        }

        public int PromptAge()
        {
            Console.Write("Please enter your age: ");
            UserAge = Int32.Parse(Console.ReadLine());
            return UserAge;

        }

        public int PromptHR()
        {
            Console.Write("Please enter your resting HR: ");
            UserHR = Int32.Parse(Console.ReadLine());
            return UserHR;
        }


        public static void IntensityHRDisplay()
        {
            Calc calc = new Calc();
            Dictionary<int,int> intRateDict = calc.GenIntRateDict();

            foreach (var item in intRateDict)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Intensity: {item.Key}%");
                Console.WriteLine($"Target Heart Rate: {item.Value} BPM");
                Console.WriteLine("----------------------------");

            }
        }




    }
}
