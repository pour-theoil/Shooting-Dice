using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; } = "your mother hamster";


         public override int Roll(int other)
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"Smack talking player shouts a taunt... {Taunt}");
            return new Random().Next(DiceSize) + 1;
        }
        
    
    }
}