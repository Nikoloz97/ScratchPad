using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    public class UI
    {
        public void Run()
        {
            WelcomeScreen();
        }

        public static void WelcomeScreen()
        {
            Console.WriteLine("Welcome to LeetCode!");
            Console.WriteLine("Where leetcode functions I painstakingly try to solve are all placed here");
            Console.WriteLine("Which function would you like to check out?");
            Console.WriteLine("1 - ClimbStairs");
            Console.WriteLine("2 - MaxArea");
            Console.WriteLine("3 - MissingNumbs");
            Console.WriteLine("4 - Palindrome");
            Console.WriteLine("5 - RomanNumeralConverter");
            Console.WriteLine("6 - TableCreator");

            string rawUserInput = Console.ReadLine();

            //TODO: Create function in UI_Helper that throws user input in while loop until get valid input (can be parsed and in-range) 
            bool isParsed = int.TryParse(rawUserInput, out int UserInput);

        }
    }
}
