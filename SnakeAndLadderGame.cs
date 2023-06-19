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
        public void Snake_and_Ladder()
        {
            Console.WriteLine("Snake and Ladder Game!");
            int presentPosition = 0;
            int diceRolls = 0;

            Random rnd = new Random();

            while (presentPosition < 100)
            {
                // to generate dice value from 1 to 6
                int diceValue = rnd.Next(1,7);
                diceRolls++;
                Console.WriteLine("your dice value: " + diceValue);
                // To check if the player lands on ladder or snake.

                int options = rnd.Next(0, 3);
                switch (options)
                {
                    case 0:
                        Console.WriteLine("No play!, You stay in the same position");
                        break;
                    case 1:
                        presentPosition += diceValue;
                        Console.WriteLine("Cool!, You landed on a ladder. You're going ahead by" + diceValue + "Position");
                        break;
                    case 2:
                        presentPosition -= diceValue;
                        if (presentPosition < 0)
                        {
                            presentPosition = 0;
                        }
                        Console.WriteLine("Sorry! You landed on a snake. You're going behind by " + diceValue + "Position");
                        break;
                }
                // Move the player back if they exceed position 100
                if (presentPosition > 100)
                {
                    presentPosition -= (presentPosition - 100); 
                }

                Console.WriteLine("Your current position is " + presentPosition);
                Console.WriteLine();
            
            }
            Console.WriteLine("Congratulations! You reached position 100.");
            Console.WriteLine("Total dice rolls: " + diceRolls);
            Console.ReadLine();

        }
    }
}
