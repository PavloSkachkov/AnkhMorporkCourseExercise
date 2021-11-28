using System;

namespace AnkhMorporkCourseExercise
{
    class Program
    {
        static void Main(string[] args)
        {

         var rnd = new Random();
         var player = new Player();
         var assassinsEncounter = new AssassinsEncounter();
         var thievesEncounter = new ThievesEncounter();
         var beggars = new Beggar[11]
         {
             new Beggar("Twitcher", 3),
             new Beggar("Drooler", 2),
             new Beggar("Dribbler", 1),
             new Beggar("Mumbler", 1),
             new Beggar("Mutterers", 0.9),
             new Beggar("Walking-Along-Shouter", 0.8),
             new Beggar("Demander of a Chip", 0.6),
             new Beggar("The one, who Call Other People Jimmy", 0.5),
             new Beggar("The one, who Need Eightpence For A Meal", 0.08),
             new Beggar("The one, who Need Tuppence For A Cup Of Tea", 0.02),
             new Beggar("People With Placards Saying 'Why lie? I need a beer.'", 0)
         };
         var beggarsEncounter = new BeggarsEncounter(beggars);
         var foolsEncounter = new FoolsEncounter();

            Console.WriteLine(" Well, hello there and welcome to the fine city of Ankh-Morpork!\n" +
                              " You're here with 100 AM$ (Ankh-Morpork dollar). Try to survive and remember to have fun.");
            while (player.moneyAmount > 0)
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
