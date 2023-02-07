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
            IList<string> combinations = new List<string>();

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

            return combinations;

        }




        public IList<String> CombListCreator_1(string digits)
        {
            IList<string> combinationsList = new List<string>();


            IEnumerable<string> enumButtonChars = from keyValue in phoneButtons where keyValue.Key == digits[0] select keyValue.Value;
            string buttonChars = enumButtonChars.ToString();

            foreach (var item in buttonChars)
            {
                combinationsList.Add(item.ToString());

            }
            return combinationsList;

        }

        public IList<String> CombListCreator_2(string digits)
        {
            IList<string> combinationsList = new List<string>();

            IEnumerable<string> enumButtonChars_1 = from keyValue in phoneButtons where keyValue.Key == digits[0] select keyValue.Value;
            string buttonChars_1 = enumButtonChars_1.ToString();

            IEnumerable<string> enumButtonChars_2 = from keyValue in phoneButtons where keyValue.Key == digits[1] select keyValue.Value;
            string buttonChars_2 = enumButtonChars_2.ToString();

            string combination = string.Empty;

            foreach (var item1 in buttonChars_1)
            {
                combination += item1;

                foreach (var item2 in buttonChars_2)
                {
                    combination += item2;

                    combinationsList.Add(combination);

                    combination.Remove(1);
                }

                combination.Remove(0);
            }

            return combinationsList;

        }

        public IList<String> CombListCreator_3(string digits)
        {
            IList<string> combinationsList = new List<string>();

            IEnumerable<string> enumButtonChars_1 = from keyValue in phoneButtons where keyValue.Key == digits[0] select keyValue.Value;
            string buttonChars_1 = enumButtonChars_1.ToString();

            IEnumerable<string> enumButtonChars_2 = from keyValue in phoneButtons where keyValue.Key == digits[1] select keyValue.Value;
            string buttonChars_2 = enumButtonChars_2.ToString();

            IEnumerable<string> enumButtonChars_3 = from keyValue in phoneButtons where keyValue.Key == digits[1] select keyValue.Value;
            string buttonChars_3 = enumButtonChars_3.ToString();


            string combination = string.Empty;

            foreach (var item1 in buttonChars_1)
            {
                combination += item1;

                foreach (var item2 in buttonChars_2)
                {
                    combination += item2;

                    foreach (var item3 in buttonChars_3)
                    {
                        combination += item3;
                        combinationsList.Add(combination);
                        combination.Remove(2);
                    }

                    combination.Remove(1);
                }

                combination.Remove(0);
            }

            return combinationsList;
        }

        public IList<String> CombListCreator_4(string digits)
        {
            IList<string> combinationsList = new List<string>();

            IEnumerable<string> enumButtonChars_1 = from keyValue in phoneButtons where keyValue.Key == digits[0] select keyValue.Value;
            string buttonChars_1 = enumButtonChars_1.ToString();

            IEnumerable<string> enumButtonChars_2 = from keyValue in phoneButtons where keyValue.Key == digits[1] select keyValue.Value;
            string buttonChars_2 = enumButtonChars_2.ToString();

            IEnumerable<string> enumButtonChars_3 = from keyValue in phoneButtons where keyValue.Key == digits[1] select keyValue.Value;
            string buttonChars_3 = enumButtonChars_3.ToString();

            IEnumerable<string> enumButtonChars_4 = from keyValue in phoneButtons where keyValue.Key == digits[1] select keyValue.Value;
            string buttonChars_4 = enumButtonChars_4.ToString();

            string combination = string.Empty;



            foreach (var item1 in buttonChars_1)
            {
                combination += item1;

                foreach (var item2 in buttonChars_2)
                {
                    combination += item2;

                    foreach (var item3 in buttonChars_3)
                    {
                        combination += item3;

                        foreach (var item4 in buttonChars_3)
                        {
                            combination += item4;
                            combinationsList.Add(combination);

                        }
                        combination.Remove(2);
                    }

                    combination.Remove(1);
                }

                combination.Remove(0);
            }

            return combinationsList;

        }
    }
}
