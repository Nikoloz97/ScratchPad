using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad
{
    public class UI_Helper
    {
        public static int ProperUserInput_Integer(string userInput, int UpperRangeInclusive)
        {
            bool isParsed = int.TryParse(userInput, out int result);

            while (true)
            {
            if (userInput == null)
            {
                Console.WriteLine("You didn't put in anything. Try again");
            }
            else if (!isParsed)
            {
                Console.WriteLine("Input was not a number. Try again");
            }
            else if (result <= 0)
            {
                Console.WriteLine("Input was too low. Try again");
            }
            else if (result > UpperRangeInclusive)
            {
                Console.WriteLine("Input was too high. Try again");

            }
            else { return result; }

            }




        }

        public static string ProperUserInput_String(string userInput)
        {

            while (true)
            {
                if (userInput == null)
                {
                    Console.WriteLine("You didn't put in anything. Try again");
                }

                else if (userInput == String.Empty)
                {
                    Console.WriteLine("You actually didn't put in anything. Try again");
                }
                else { return userInput; }

            }




        }
    }
}
