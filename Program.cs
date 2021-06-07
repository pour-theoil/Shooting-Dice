using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)

        {
        
            Console.Clear();
            Player player1 = new HumanPlayer();
            player1.Name = "Human";

            Player smack = new SmackTalkingPlayer();
            smack.Name = "Sue";
           

            // smack.Play(player1);
            
            // Console.WriteLine("-------------------");

            Player player3 = new OneHigherPlayer();
            player3.Name = "Wilma";

            // player3.Play(smack);

            // Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            // player1.Play(large);

            // Console.WriteLine("-------------------");


            CreativeSmackTalkingPlayer creative = new CreativeSmackTalkingPlayer();
            creative.Taunts.Add("Your mother was a hamster");
            creative.Taunts.Add("Are you even trying?");
            creative.Taunts.Add("Im almost asleep over here");
            creative.Taunts.Add("Watch out Im playing here...");
            creative.Name = "zenith";

            Player upper = new UpperHalfPlayer();
            upper.Name = "Joe lucky";

            Player uppersore = new SoreLoserUpperHalfPlayer();
            uppersore.Name = "Donald";

            List<Player> players = new List<Player>() {
                player1, smack, player3, large, creative, upper, uppersore
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}