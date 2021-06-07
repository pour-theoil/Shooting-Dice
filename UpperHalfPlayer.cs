using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
         public override int Roll(int other)
        {
            while (true)
            {
                int upper = new Random().Next(DiceSize) + 1;
                if (upper > 3)
                {
                    return upper;
                }
            }
            // Return a random number between 1 and DiceSize
            
        }
    }
}