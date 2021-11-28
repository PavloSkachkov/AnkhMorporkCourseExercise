using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AnkhMorporkCourseExercise
{
    public class ThievesEncounter : IEncounter
    {
        private Thiev thiev = new Thiev();
        public void Action(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (thiev.CurrentThefts != thiev.AcceptableNumberOfThefts)
            {
                Console.WriteLine("---------------------------\n Out of nowhere you feel a piece of cold, sharp steel pressed firmly against your back and hear a voice,\n" +
                                  " just as cold, demanding to choose between a little payment and your life.\n" +
                                  " You can give some money (type 'm') or give up (type 'u')");
                var answer = Console.ReadLine();
                switch (answer)
                {
                    case "m":
                    {
                        Acception(player);
                    }
                        break;
                    case "u":
                    {
                        Decline(player);
                    }
                        break;
                    default:
                    {
                        Console.WriteLine(
                            "---------------------------\n You need to choose\n---------------------------");
                        Action(player);
                    }
                        break;
                }
            }
            else
                Console.WriteLine("You're lucky. We did everything we wanted for today.");

            Console.WriteLine("---------------------------");
            Console.ResetColor();
        }

        public void Acception(Player player)
        {
            player.moneyAmount -= thiev.Fee;
            thiev.CurrentThefts++;
        }

        public void Decline(Player player)
        {
            player.moneyAmount -= player.moneyAmount;
            Console.WriteLine("Even though you decided on resisting, there's little you could do against a dagger. Oops.");
        }
    }
}
