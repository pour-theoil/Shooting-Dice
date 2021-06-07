using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
         public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            int roll;
            while (true)
            {

            Console.WriteLine("Enter a roll of a dice! ");
            string stringroll = Console.ReadLine();
            if (int.TryParse(stringroll, out roll) && roll > 0 && roll< 7)
            {
                break;
            }
            }


            return roll;
        }
    }
}