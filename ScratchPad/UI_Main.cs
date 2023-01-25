﻿using ScratchPad.Karvonen;
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
            Console.WriteLine("2 - Exit");
            Console.WriteLine();
            Console.Write("Your choice: ");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    UI.IntensityHRDisplay();
                    break;
                case 2:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }


        }


    }
}