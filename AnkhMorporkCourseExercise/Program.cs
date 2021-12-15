using System;
using AnkhMorporkCourseExercise.Encounters;
using AnkhMorporkCourseExercise.Models;
using AnkhMorporkCourseExercise.Repositories;

namespace AnkhMorporkCourseExercise
{
    class Program
    {
        static void Main(string[] args)
        {

         var player = new Player();

         var assassinsEncounter = new AssassinsEncounter(ConsoleColor.Red, LinesRepository.AssassinsStartLine, LinesRepository.AssassinsEndLine, new AssassinsRepository());
         var thievesEncounter = new ThievesEncounter(ConsoleColor.Magenta, LinesRepository.ThievesStartLine, LinesRepository.ThievesEndLine, new ThievesRepository());
         var beggarsEncounter = new BeggarsEncounter(ConsoleColor.Green, LinesRepository.BeggarsStartLine, LinesRepository.BeggarsEndLine, new BeggarsRepository());
         var foolsEncounter = new FoolsEncounter(ConsoleColor.Yellow, LinesRepository.FoolsStartLine, LinesRepository.FoolsEndLine, new FoolsRepository());

         var rnd = new Random();

            Console.WriteLine(" Well, hello there and welcome to the fine city of Ankh-Morpork!\n" +
                              " You're here with 100 AM$ (Ankh-Morpork dollar). Try to survive and remember to have fun.");
            while (player.IsAlive)
            {
                switch (rnd.Next(0, 4))
                {
                    // Assassins
                    case 0:
                        {
                            assassinsEncounter.Action(player);
                            Console.WriteLine($"{player}");
                        }
                        break;
                    //Thieves
                    case 1:
                        {
                            thievesEncounter.Action(player);
                            Console.WriteLine($"{player}");
                        }
                        break;
                    //Beggars
                    case 2:
                        {
                            beggarsEncounter.Action(player);
                            Console.WriteLine($"{player}");
                        }
                        break;
                    //Fools
                    case 3:
                        {
                            foolsEncounter.Action(player);
                            Console.WriteLine($"{player}");
                        }
                        break;

                }
            }

            Console.WriteLine(" You are dead!\n Thanks for playing.");
        }
    }
}
