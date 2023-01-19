using System;
// Allows you to create lists/arrays
using System.Collections.Generic;
// Allows you to use Console.ReadLine()
using System.IO;
// Allows you to use query statements (like in SQL)
using System.Linq;

namespace ScratchPad
{
    // Roadmap: 
    // W3 Schools: https://www.w3schools.com/cs/cs_class_members.php
    // Learning how to document classes/functions for intellisense: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
    // Learn ASP.NET MVC: https://www.danylkoweb.com/StartHere

    class Program
    {
         static void Main(string[] args)
        {
            LeetCode lc = new LeetCode();

            Console.WriteLine(lc.IsPalindrome(12345));
            
            Console.WriteLine(lc.IsPalindrome(121));
            
            Console.WriteLine(lc.IsPalindrome(-121));

        }



        }

}

