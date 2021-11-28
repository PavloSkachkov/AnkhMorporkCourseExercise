using System;
using System.Collections.Generic;
using System.Linq;

namespace AnkhMorporkCourseExercise
{
    public class AssassinsEncounter : IEncounter
    {
        private List<Assassin> assassins = new List<Assassin>()
        {
            new Assassin(1, 3),
            new Assassin(7, 12),
            new Assassin(10, 20),
            new Assassin(15, 19),
            new Assassin(15, 30)
        };

        public void Action(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------\n You're in a Shades. It is pretty easy to get into a trouble in here.\n" +
                              " Someone will definitely kill you.\n" +
                              " You can create a contract to protect yourself (type 'c') or Skip it (type 's')");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "c":
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
            Console.WriteLine("Amount of money");
            string rewardString = Console.ReadLine();
            if (double.TryParse(rewardString, out double reward))
            {
                var assassin = assassins.FirstOrDefault(a => a.MinReward <= reward && a.MaxReward >= reward && a.IsOccupied == false);
                if (assassin == null)
                {
                    Console.WriteLine("There was no assassin for such price. You got killed.");
                    Decline(player);
                }
                else
                {
                    assassin.IsOccupied = true;
                    player.moneyAmount -= reward;
                }
            }
            else
            {
                Console.WriteLine("There was no point to joke with us.");
                Decline(player);
            }
        }
        public void Decline(Player player)
        {
            player.moneyAmount -= player.moneyAmount;
        }
    }
}
