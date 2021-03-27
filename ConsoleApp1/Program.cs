using System;
using System.Collections.Generic;
using System.Linq;

namespace KingOfTheCourt
{
    class Game
    {
        static void Main(string[] args)
        {

            // queue: 
                // add an option for deeper stats at the post-game
                // README
                // give the player the choice to take a 1 or 2 point shot
                // graph/graphic
                // Levels

            var answer = "1";
            var result = "";
            var playByPlay = new List<string>();
            
            // allow player to play again by pressing 1
            while (answer != "3") {

                Hooper player = new Hooper("Keith"); 
                Hooper player2 = new Shooter("Anne");

                // game loop
                while (player.score < 12 && player2.score < 12)
                {
                    if (player.isTurn)
                    {
                        bool result1 = player.Shoot();
                        if (result1)
                        {
                            player.madeShot();
                            playByPlay.Add($"{player.name} Attempt:{player.attempts}. Points:{player.score}");
                        }
                        else
                        {
                            player.missedShot();
                            playByPlay.Add($"{player.name} Miss");
                            player2.isTurn = true;
                        }
                    }
                    else if (player2.isTurn)
                    {
                        bool result2 = player2.Shoot();
                        if (result2)
                        {
                            player2.madeShot();
                            playByPlay.Add($"{player2.name} Attempt:{player2.attempts}. Points:{player2.score}");
                        }
                        else
                        {
                            player2.missedShot();
                            playByPlay.Add($"{player2.name} Miss");
                            player.isTurn = true;
                        }
                    }


                }

                // post-game 
                playByPlay.ForEach(Console.WriteLine);

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkYellow;

                if (player.score>player2.score)
                {
                    result += $"{player.name} wins by a score of {player.score} to {player2.score}!";
                }
                else
                {
                    result += $"{player2.name} wins by a score of {player2.score} to {player.score}!";
                }

                // player.shootingPercentage.ForEach(Console.WriteLine);
                double playerPercent = player.shootingPercentage.Average();
                

                Console.WriteLine(result);
                result = "";

                Console.ResetColor();

                Console.WriteLine("Player 1's shooting percentage was " + playerPercent * 100 + "%.");

                Console.WriteLine("Press 1 then enter to play again");
                Console.WriteLine("Press 2 then enter to see the play-by-play");
                Console.WriteLine("Press 3 then enter to exit.");
                answer = Console.ReadLine();

            }
            
            

        }
    }
}
