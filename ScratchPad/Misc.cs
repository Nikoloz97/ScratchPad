using ScratchPad.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ScratchPad
{
    // Learning random stuff
    public class Misc
    {
        public static void FizzBuzzFunction(int valueInput)
        {
            if (valueInput % 3 == 0 && valueInput % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

            else if (valueInput % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else if (valueInput % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else
            {
                Console.WriteLine(valueInput);
            }
        }


        public static void FizzBuzzFunction(int valueInput, int startingValue, int endingValue)
        {
            for (int i = startingValue; i <= endingValue; i++ )
            {

            if (valueInput % 3 == 0 && valueInput % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

            else if (valueInput % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else if (valueInput % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else
            {
                Console.WriteLine(valueInput);

            }

            }
        }

        // Below = recursion
        // Also, check out BinaryTree.cs (LeetCode) 

        /// <summary>
        /// Method <c>Factorial</c> returns a a factorial given a number <br/>
        /// <example>
        /// For example: <br/>
        /// <code>
        /// Recursion rec = new Recursion();
        /// rec.Factorial(5);
        /// </code>
        /// Returns 120... <br/>
        /// factorial(5) = return (5 x factorial(4)) <br/>
        /// -> factorial(4) = return (4 x factorial(3)) <br/>
        /// --> factorial(3) = return (3 x factorial(2)) <br/>
        /// ---> factorial(2) = return (2 x factorial(1)) <br/>
        /// ----> factorial(1) = return 1 <br/>
        /// Now it reverses back up... <br/>
        /// ---> factorial(2) = return (2 x 1) = 2 <br/>
        /// --> facorial(3) = return (3 x 2) = 6 <br/>
        /// -> factorial(4) = return (4 x 6) = 24 <br/>
        /// factorial 5 = return 5 x 24 = 120 <br/>
        /// </example>
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// 

        public int Factorial(int number)
        {
            if (number == 1) { return 1; }
            return number * Factorial(number - 1);
        }





        public string ReverseWord(string Word)
        {
            if (Word.Length == 0) { return ""; }
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


        // IComparable = used if have access to each item (i.e. Student Model)
        public void PrintStudents()
        {
            Students students = new Students();

            List<Student> studentsList = students.StudentsList;

            // Sorts based on score (see Student model)
            studentsList.Sort();

            // Sorts based on Id (see CompareStudents class on obttom of page)
            CompareStudents basedOnId = new CompareStudents();
            studentsList.Sort(basedOnId);

            foreach (Student stu in studentsList)
            {
                Console.WriteLine(stu.Id + " " + stu.FirstName + " " + stu.LastName + " " + stu.Score);

            }

        }



    }

    // IComparer = used when don't have access the each item (i.e. Student Model)
    public class CompareStudents : IComparer<Student>
    {

        public int Compare([AllowNull] Student x, [AllowNull] Student y)
        {
            // Sort based on ID
            if (x.Id > y.Id) { return 1; }
            else if (x.Id < y.Id) { return -1; }
            else { return 0; }
        }



    }
}
