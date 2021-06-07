using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        
        public List<string> Taunts { get; set; }

       public CreativeSmackTalkingPlayer(){
           Taunts = new List<string>();
       }
        
         public override int Roll(int other)
        {
            
            Random i = new Random();
        int genRand = i.Next(0, Taunts.Count - 1);
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"Creative smack talking play shouts a taunt... {Taunts[genRand]}");
            return new Random().Next(DiceSize) + 1;
        }
        
    }
}