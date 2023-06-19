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
            

            
                Random rnd = new Random();
                int diceValue = rnd.Next(1,7);
               
                Console.WriteLine("your dice value: " + diceValue);
           

        }
    }
}
