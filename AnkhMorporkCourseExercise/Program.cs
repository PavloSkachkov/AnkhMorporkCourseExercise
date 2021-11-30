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
         LinesRepository linesStorege = new LinesRepository();

         var assassinsEncounter = new AssassinsEncounter(ConsoleColor.Red, linesStorege.AssassinsStartLine, linesStorege.AssassinsEndLine, new AssassinsRepository());
         var thievesEncounter = new ThievesEncounter(ConsoleColor.Magenta, linesStorege.ThievesStartLine, linesStorege.ThievesEndLine, new Thiev());
         var beggarsEncounter = new BeggarsEncounter(ConsoleColor.Green, linesStorege.BeggarsStartLine, linesStorege.BeggarsEndLine, new BeggarsRepository());
         var foolsEncounter = new FoolsEncounter(ConsoleColor.Yellow, linesStorege.FoolsStartLine, linesStorege.FoolsEndLine, new FoolsRepository());

         var rnd = new Random();

            Console.WriteLine(" Well, hello there and welcome to the fine city of Ankh-Morpork!\n" +
                              " You're here with 100 AM$ (Ankh-Morpork dollar). Try to survive and remember to have fun.");
            while (player.IsAlive)
            {
                switch (rnd.Next(1, 5))
                {
                    // Assassins
                    case 1:
                        {
                            assassinsEncounter.Action(player);
                            Console.WriteLine($"{player}");
                        }
                        break;
                    //Thieves
                    case 2:
                        {
                            thievesEncounter.Action(player);
                            Console.WriteLine($"{player}");
                        }
                        break;
                    //Beggars
                    case 3:
                        {
                            beggarsEncounter.Action(player);
                            Console.WriteLine($"{player}");
                        }
                        break;
                    //Fools
                    case 4:
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
