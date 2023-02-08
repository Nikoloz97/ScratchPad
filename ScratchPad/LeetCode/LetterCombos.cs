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
        // Constraint = digits.Length = 0 - 4 

        Dictionary<char, string> phoneButtons = new Dictionary<char, string>()
        {
            {'2', "abc" },
            {'3', "def" },
            {'4', "ghi" },
            {'5', "jkl" },
            {'6', "mno" },
            {'7', "pqrs" },
            {'8', "tuv" },
            {'9', "wxyz" }

        };

        public IList<string> GetLetterCombinations(string digits) 
        {

            switch (digits.Length)
            {
                case 0:
                    break;
                case 1:
                    return CombListCreator_1(digits);
                case 2:
                    return CombListCreator_2(digits);
                case 3:
                    return CombListCreator_3(digits);
                case 4:
                    return CombListCreator_4(digits);
            }

          

            return new List<string>();

        }




        public IList<String> CombListCreator_1(string digits)
        {
            IList<string> combinationsList = new List<string>();

            string buttonChars = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[0]).Value;

            foreach (char item in buttonChars)
            {
                combinationsList.Add(item.ToString());
            }
            return combinationsList;

        }

        public IList<String> CombListCreator_2(string digits)
        {
            IList<string> combinationsList = new List<string>();

            string buttonChars_1 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[0]).Value;

            string buttonChars_2 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[1]).Value;

            string combination = string.Empty;

            foreach (char item1 in buttonChars_1)
            {
                combination += item1;

                foreach (char item2 in buttonChars_2)
                {
                    combination += item2;

                    combinationsList.Add(combination);

                    combination = combination.Remove(1);
                }

                combination = combination.Remove(0);
            }

            return combinationsList;

        }

        public IList<String> CombListCreator_3(string digits)
        {
            IList<string> combinationsList = new List<string>();

            string buttonChars_1 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[0]).Value;

            string buttonChars_2 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[1]).Value;

            string buttonChars_3 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[2]).Value;


            string combination = string.Empty;

            foreach (char item1 in buttonChars_1)
            {
                combination += item1;

                foreach (char item2 in buttonChars_2)
                {
                    combination += item2;

                    foreach (char item3 in buttonChars_3)
                    {
                        combination += item3;
                        combinationsList.Add(combination);
                        combination = combination.Remove(2);
                    }

                    combination = combination.Remove(1);
                }

                combination = combination.Remove(0);
            }

            return combinationsList;
        }

        public IList<String> CombListCreator_4(string digits)
        {
            IList<string> combinationsList = new List<string>();

            string buttonChars_1 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[0]).Value;

            string buttonChars_2 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[1]).Value;

            string buttonChars_3 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[2]).Value;

            string buttonChars_4 = phoneButtons.FirstOrDefault(keyvalue => keyvalue.Key == digits[3]).Value;



            string combination = string.Empty;


            foreach (char item1 in buttonChars_1)
            {
                combination += item1;

                foreach (char item2 in buttonChars_2)
                {
                    combination += item2;

                    foreach (char item3 in buttonChars_3)
                    {
                        combination += item3;

                        foreach (char item4 in buttonChars_3)
                        {
                            combination += item4;
                            combinationsList.Add(combination);
                            combination = combination.Remove(3);
                        }
                        combination = combination.Remove(2);
                    }

                    combination = combination.Remove(1);
                }

                combination = combination.Remove(0);
            }

         

            return combinationsList;

        }
    }
}
