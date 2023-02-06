using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace ScratchPad.LeetCode
{
    public class LetterCombos
    {
        // https://leetcode.com/problems/letter-combinations-of-a-phone-number/
        public IList<string> GetLetterCombinations(string digits) 
        {
            // E.g. 2, 4, 6
            // Create dictionary
            // Create string array
            // Create empty list

            // For each digit (key) in string...
                // Add it to a string array

            // For each item in string array (i)...
                // Loop through each char of string variable (j)... 
                        // Each time, adding string[j] of each of the rest of items in string array to a "combination" string
                // Once combination string is as long as digits, add to list
           
            // Return list


            var phoneButtons = new Dictionary<int, string>() {
                {'2', "abc" },
                {'3', "def" },
                {'4', "ghi" },
                {'5', "jkl" },
                {'6', "mno" },
                {'7', "pqrs" },
                {'8', "tuv" },
                {'9', "wxyz" }
            };

            IList<string> combinations = new List<string>();

            // For each of the characters in digits... 
            for (int i = 0; i < digits.Length; i++)
            {
                // Find matching string value (Linq)
                IEnumerable<string> enumButtonChars = from keyValue in phoneButtons where keyValue.Key == digits[i] select keyValue.Value;
                string buttonChars = enumButtonChars.ToString();

                // For each item of that string...
                for (int j = 0; j < buttonChars.Length; j++)
                {
                    // Create combination string (starting with that item)
                    string combination = string.Empty;
                    combination += buttonChars[j];

                    // For each of the next characters in digits...
                    for (int k = i; k < digits.Length - i; k++)
                    {
                        // Find matching string value (Linq)
                        IEnumerable<string> nextEnumButtonChars = from keyValue in phoneButtons where keyValue.Key == digits[i] select keyValue.Value;
                        string nextButtonChars = nextEnumButtonChars.ToString();

                        // Add to combination string
                        combination += buttonChars[k];


                    }

                    // Add combination to list
                    combinations.Add(combination);

                }
                
           
            }

            return combinations;

        }
    }
}
