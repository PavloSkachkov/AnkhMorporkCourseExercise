using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkhMorporkCourseExercise
{
    public class BeggarsEncounter : IEncounter
    {
        private Beggar[] Beggars;
        Random rnd;

        public BeggarsEncounter(Beggar[] beggars, Random rnd = default(Random))
        {
            this.Beggars = beggars;
            this.rnd = rnd ?? new Random();

        }
        public void Action(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------\n Suddenly, you feel a rough pat on your shoulder. You turn around to see a beggar, a plea in his eyes.\n" +
                              " You can give an Alm (type 'a') or Skip it (type 's')");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "a":
                {
                    Acception(player);
                }
                    break;
                case "s":
                {
                    Decline(player);
                }
                    break;
                default:
                {
                    Console.WriteLine("---------------------------\n You need to choose\n---------------------------");
                    Action(player);
                }
                    break;
            }
            Console.WriteLine("---------------------------");
            Console.ResetColor();
        }

        public void Acception(Player player)
        {
            var beggar = Beggars[rnd.Next(0, 11)];
            player.moneyAmount -= beggar.Alm;
        }

        public void Decline(Player player)
        {
            player.moneyAmount -= player.moneyAmount;
            Console.WriteLine(" Your attempt to leave was fruitless - no matter what you do you cant escape the feel of constant chase." +
                              " Your hindered sanity has eventually led you to your impending doom and slow, inevitable death. Sucks to be you.");
        }
    }
}
