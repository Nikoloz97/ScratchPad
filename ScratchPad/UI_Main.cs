using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad
{
    public class UI_Main
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Nick's .NET Sandbox!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Please choose from the following options: ");
            Console.WriteLine("1 - Karvonen Heart Calculator");
            Console.WriteLine("2 - LeetCode Functions");
            Console.WriteLine("3 - WebGenerator");
            Console.WriteLine("4 - NBA Trivia");
            Console.WriteLine("5 - Exit");
            Console.WriteLine();

            // Test to see if DB works
            string ConnectionString_LeetCode = @"Data Source=c:\LeetCodeDB.db; Version=3;";

            LeetCode.SQL sql = new LeetCode.SQL(ConnectionString_LeetCode);
            sql.WriteOutCitiesFromAddressTable();


            Console.Write("Your choice: ");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    Karvonen.UI.WelcomeScreen();
                    Karvonen.UI.RunHRIntensity();
                    break;
                case 2:
                    Console.Clear();
                   /* LeetCode.UI.DisplayData();*/
                    break;
                case 3:
                    Console.Clear();
                    break;

            }


        }


    }
}
