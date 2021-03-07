﻿using System;

namespace KingOfTheCourt
{
    class Game
    {
        static void Main(string[] args)
        {
            
          
            var answer = "1";

            while (answer == "1") {

                Hooper player = new Hooper("Keith");
                Hooper player2 = new Hooper("Anne");

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