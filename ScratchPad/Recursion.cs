using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad
{
    public class Recursion
    {
        public int Factorial(int number)
        {
            if (number == 1) { return 1; }
            return number * Factorial(number - 1);
        }


        // factorial 5 = return (5 x factorial(4))
        // -> factorial(4) = return (4 x factorial(3))
        // --> factorial(3) = return (3 x factorial(2));
        // ---> factorial(2) = return (2 x factorial(1));

        // ----> factorial(1) = return 1

        // Now it reverses back up...

        // ---> factorial(2) = return (2 x 1) = 2;
        // --> facorial(3) = return (3 x 2) = 6;
        // -> factorial(4) = return (4 x 6) = 24;
        // factorial 5 = return 5 x 24 = 120;


        public string ReverseWord(string Word)
        {
            if (Word.Length == 0) { return "";}
            return ReverseWord(Word.Substring(1)) + Word[0];
        }

        // ReverseWord("Hello") = return ReverseWord(ello) + H;
        // -> ReverseWord(ello) = return ReverseWord(llo) + e;
        // --> ReverseWord(llo) = return ReverseWord(lo) + l;
        // ---> ReverseWord(lo) = return ReverseWord(o) + l;
        // ----> ReverseWord(o) = return ReverseWord() + o;
        // -----> ReverseWord() = return "";

        // Now it reverses back up...

        // ----> ReverseWord(o) = return o;
        // ---> ReverseWord(lo) = return o + l;
        // --> ReverseWord(llo) = return ol + l;
        // -> ReverseWord(ello) = oll + e;
        // ReverseWord("Hello") = olle + H;

        public int CountDown(int Value)
        {

            if (Value == 0) 
            {
                Console.WriteLine(Value);
                Console.WriteLine("Buhya");
                return 0;
            }
            Console.WriteLine(Value);
            return CountDown(Value - 1) + 1;
            
        }

        // Countdown(3) = 2 + 1; -> 3
        // Countdown(2) = 1 + 1; -> 2
        // Countdown(1) = 0 + 1; -> 1
        // Countdown(0) = 0;  -> 0 + Buhya


        public int SumRange(int Value)
        {
            if (Value == 0)
            {
                return 0;
            }
            return Value + SumRange(Value - 1);
        }
   



    }
}
