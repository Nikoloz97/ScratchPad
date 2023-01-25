using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad
{
    // Miscellanous stuff


    internal class Misc
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

       
    }
}
