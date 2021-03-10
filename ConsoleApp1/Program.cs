using System;
using System.Collections.Generic;
using System.Linq;

namespace KingOfTheCourt
{
    class Game
    {
        static void Main(string[] args)
        {

            // queue: create a List variable to add each player's action
                // var play-by-play = new List<string> { "miss","make" };
                // loop through each at the end of the game
            // use a LINQ query to calculate scoring % for each player
                // var possessions = new List<int> { 1, 0, 1, 0 };
                // double scoringPercentage = possessions.Average();
            // create a Shooter class that inherits from Hooper
            // README
            // give the player the choice to take a 1 or 2 point shot


            var answer = "1";

            while (answer == "1") {

                Hooper player = new Hooper("Keith");
                Hooper player2 = new Hooper("Anne", 9);

                while (player.score < 12 && player2.score < 12)
                {
                    if (player.isTurn)
                    {
                        bool result1 = player.Shoot();
                        if (result1)
                        {
                            player.madeShot();
                        }
                        else
                        {
                            player.missedShot();
                            player2.isTurn = true;
                        }
                    }
                    else if (player2.isTurn)
                    {
                        bool result2 = player2.Shoot();
                        if (result2)
                        {
                            player2.madeShot();
                        }
                        else
                        {
                            player2.missedShot();
                            player.isTurn = true;
                        }
                    }


                }

                Console.WriteLine("Press 1 then hit enter to play again. Press anything else then enter to exit.");
                answer = Console.ReadLine();

            }
            
            

        }
    }
}
