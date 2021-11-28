using System;

namespace AnkhMorporkCourseExercise
{
    public class FoolsEncounter : IEncounter
    {
        private Fool[] fools = new Fool[9]
        {
            new Fool("Muggin", 0.5),
            new Fool("Gull", 1),
            new Fool("Dupe", 2),
            new Fool("Butt", 3),
            new Fool("Fool", 5),
            new Fool("Tomfool", 6),
            new Fool("Stupid Fool", 7),
            new Fool("Arch Fool", 8),
            new Fool("Complete Fool", 10)
        };
        public void Action(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------\n While walking down the street, you sight a fool rapidly approaching you, offering you an ordeal.\n" +
                              " You can earn some money by replacing him for today (type 'e') or Skip it (type 's')");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "e":
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
            var rnd = new Random();
            var fool = fools[rnd.Next(0, 9)];
            player.moneyAmount += fool.Earnings;
        }

        public void Decline(Player player)
        {
            Console.WriteLine("After giving it some thought, you decided on declining his generous offer.");
        }
    }
}
