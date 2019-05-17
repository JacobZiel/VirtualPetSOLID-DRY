using SOLIDandDRYvirtualPet.GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDandDRYvirtualPet
{
    class GameStart
    {
        public static void GameStartNow()
        {
            string logo = $@"
   Welcome to Virtual Pet DRY&SOLID ver.0.5
  _   ___     __            __  ___      __ 
 | | / (_)___/ /___ _____ _/ / / _ \___ / /_
 | |/ / / __/ __/ // / _ `/ / / ___/ -_) __/
 |___/_/_/  \__/\_,_/\_,_/_/ /_/   \__/\__/
                                                               ";
            Console.WriteLine(logo);

            SwitchChoiceClass.SwitchChoice();

        }
    }
}
