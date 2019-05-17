using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDandDRYvirtualPet.GameLogic;

namespace SOLIDandDRYvirtualPet.GameLogic
{
    class SwitchChoiceClass
    {
        public static void SwitchChoice()

        {
            var petStats = new PetClass();
            Console.WriteLine(" Name your Pet");
            petStats.Name = Console.ReadLine();   
            while (petStats.Sleep >= 1 ^ petStats.Food >= 1 ^ petStats.Play >= 1)
            {
                Console.WriteLine(" 1 for Stats, 2 for Feed,  for Sleep, 4 to Play");
            var choice = Console.ReadLine();
                var info = $" Name: {petStats.Name}, Hunger: {petStats.Food}, Tiredness: {petStats.Sleep}, Boredom: {petStats.Play}";

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(info);
        
                        break;
                    case "2":
                        petStats.Food++;
                        petStats.Sleep--;
                        Console.WriteLine(petStats.Food);
                        Console.WriteLine(info);
           
                        break;
                    case "3":
                        petStats.Sleep++;
                        Console.WriteLine(petStats.Sleep);
                        Console.WriteLine(info);
                    
                        break;
                    case "4":
                        petStats.Play++;
                        Console.WriteLine(petStats.Play);
                        Console.WriteLine(info);
                 
                        break;
                    default:
                        Console.WriteLine(" Something went wrong!");
                        break;

 
                }
             

            }
            GameOverClass.GameOver();


        }

    }
}
