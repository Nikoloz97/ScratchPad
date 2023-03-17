using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    // https://leetcode.com/problems/multiply-strings/
    public class Multiply
    {
        public string MultiplyStrings(string num1, string num2)
        {

            long firstVal = Int64.Parse(num1);
            long secondVal = Int64.Parse(num2);
            long productVal = firstVal * secondVal;

            bool isShortened = false;

            while (productVal < 0)
            {
                isShortened= true;
                // Divide productVal by 100, then foreach loop where you get rid of decimal
                long shortenedfirstVal = firstVal / 100;
                long shortenedsecondVal = secondVal / 100;

                productVal = shortenedfirstVal * shortenedsecondVal;

            }

            if (isShortened)
            {
                string returnedString = "";

                foreach (var item in productVal.ToString())
                {
                    returnedString += item; 
                }
                
                return returnedString;

            }
            
            return productVal.ToString();
 
        }
    }
}
