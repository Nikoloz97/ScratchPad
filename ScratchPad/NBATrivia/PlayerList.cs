using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.NBATrivia
{
    public class PlayerList
    {
        public static void GenerateFourEmployees()
        {
            // Create new array List
            ArrayList players = new ArrayList();


            // Use employee class like a function (when instantiating an object) 
            // Curly brackets = what each class attributes will equal to
            players.Add(new Player() { Id = 1, FirstName = "E1" });
            players.Add(new Player() { Id = 2, FirstName = "E2" });
            players.Add(new Player() { Id = 3, FirstName = "E3" });
            players.Add(new Player() { Id = 4, FirstName = "E4" });

            foreach (Player player in players)
            {
                Console.WriteLine(player);

            }
        }
    }
}
