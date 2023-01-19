using System;
// Allows you to create lists/arrays
using System.Collections.Generic;
// Allows you to use Console.ReadLine()
using System.IO;
// Allows you to use query statements (like in SQL)
using System.Linq;

namespace ScratchPad
{
     class Program
    {
        string color;
        int maxSpeed;
        public string FullThrottle()
        {
            return "This car is going super fast!";
        }
        
         static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.color = "red";
            myProgram.maxSpeed = 200;

            Console.WriteLine(myProgram.FullThrottle());
        }










        // Fizzbuzz practice...

     /*   public static void FizzBuzzFunction(int valueInput)
        {
            if (valueInput % 3 == 0 && valueInput % 5 == 0) {
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

        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                FizzBuzzFunction(i);
            }
        }*/



        }

}

