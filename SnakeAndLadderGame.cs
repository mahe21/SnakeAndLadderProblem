using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblems
{
    public class SnakeAndLadderGame
    {
        int presentPosition = 0;
        int diceRolls = 0;
        int diceValue;
        int options;
        Random rnd = new Random();
        public void Snake_and_Ladder()
        {
            Console.WriteLine("Snake and Ladder Game!");
            
            

            while (presentPosition < 100)
            {
                
                int diceValue = rnd.Next(1,7);
                diceRolls++;
                Console.WriteLine("your dice value: " + diceValue);
                DiceOptions();
                


                
            }

        }
        public void DiceOptions()
        {
            int options = rnd.Next(0, 3);
            switch (options)
            {
                case 0:
                    Console.WriteLine("No play!, You stay in the same position");
                    break;
                case 1:
                    presentPosition = presentPosition + diceValue;
                    Console.WriteLine("Cool!, You landed on a ladder. You're going ahead by" + diceValue + "Position");
                    break;
                case 2:
                    presentPosition = presentPosition - diceValue;
                    if (presentPosition < 0)
                    {
                        presentPosition = 0;
                    }
                    Console.WriteLine("Sorry! You landed on a snake. You're going behind by " + diceValue + "Position");
                    break;
            }
        }
    }
}
