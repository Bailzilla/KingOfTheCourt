using System;
using System.Collections.Generic;
using System.Linq;

namespace KingOfTheCourt
{
    class Game
    {
        static void Main(string[] args)
        {
            var answer = "1";
            var result = "";
            var playByPlay = new List<string>();
            
            // main loop
            while (answer != "3") {

                Hooper player = new Hooper("Keith");
                Hooper player2 = new Shooter("Anne");

                if (answer == "1")
                {
                    // clear the results of last game before starting a new
                    if (playByPlay.Count > 0)
                    {
                        playByPlay.Clear();
                    }

                    // play loop
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
                    
                    // determining winner and displaying results
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (player.score > player2.score)
                    {
                        result += $"{player.name} wins by a score of {player.score} to {player2.score}!";
                    }
                    else
                    {
                        result += $"{player2.name} wins by a score of {player2.score} to {player.score}!";
                    }
                    Console.WriteLine(result);
                    result = "";

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    double playerPercent = player.shootingPercentage.Average();
                    double player2Percent = player2.shootingPercentage.Average();
                    Console.WriteLine(player.name +"'s shooting percentage was " + playerPercent * 100 + "%.");
                    Console.WriteLine(player2.name + "'s shooting percentage was " + player2Percent * 100 + "%.");

                }
                else if (answer == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    playByPlay.ForEach(Console.WriteLine);
                } 

                // post-game 
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("Press 1 then enter to play again");
                Console.WriteLine("Press 2 then enter to see the play-by-play");
                Console.WriteLine("Press 3 then enter to exit.");

                answer = Console.ReadLine();
            }
        }
    }
}
