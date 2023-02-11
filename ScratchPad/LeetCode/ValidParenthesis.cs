using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad.LeetCode
{
    // https://leetcode.com/problems/valid-parentheses/
    public class ValidParenthesis
    {
        private readonly List<Parenthesis> ParenthesisList = new List<Parenthesis>()
            {
                new Parenthesis()
                {
                    Opening = '(',
                    Closing = ')'
                },
                new Parenthesis()
                {
                    Opening = '{',
                    Closing = '}'
                },
                new Parenthesis()
                {
                    Opening = '[',
                    Closing = ']'
                }
            };
        public bool IsValid(string s)
        {
            List<char> OpeningList = ParenthesisList.Select(parenthesis => parenthesis.Opening).ToList();
            List<char> ClosingList = ParenthesisList.Select(parenthesis => parenthesis.Closing).ToList();


            if (!OpeningList.Contains(s[0]) || s.Length % 2 !=0)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {

                if (OpeningList.Contains(s[i]))
                {
                    if (ClosingList.Contains(s[i+1]) && (OpeningList.IndexOf(s[i]) == ClosingList.IndexOf(s[i+1])))
                    {
                        i++;
                    }
                    else { return false; }

                }
                else
                {
                    return false;
                }

            }
            return true;
            


        }
    }

    public class Parenthesis
    {

        public char Opening { get; set;}
        public char Closing { get; set;}  
    }
}
