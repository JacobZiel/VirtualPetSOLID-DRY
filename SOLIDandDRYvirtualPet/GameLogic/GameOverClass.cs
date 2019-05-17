using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDandDRYvirtualPet.GameLogic
{
    class GameOverClass
    {
        public static void GameOver()
        {
            string gameOverLogo = $@"
  _____                 ____              
 / ___/__ ___ _  ___   / __ \_  _____ ____
/ (_ / _ `/  ' \/ -_) / /_/ / |/ / -_) __/
\___/\_,_/_/_/_/\__/  \____/|___/\__/_/   
                                         
   Your pet died,type 1 if you like to play again. 
                                                               ";
            Console.WriteLine(gameOverLogo);
            var finalChoice = Console.ReadLine();
            switch (finalChoice)
            {
                case "1":
                    GameStart.GameStartNow();
                    break;
                default:
                    Console.WriteLine(" BYE");
                    break;
            }


        }
    }
}
2
2
