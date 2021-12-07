using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AnkhMorporkCourseExercise.Models;
using AnkhMorporkCourseExercise.Repositories;

namespace AnkhMorporkCourseExercise.Encounters
{
    class AssassinsEncounter : BaseEncounter<Assassin>
    {
        private readonly IRepository<Assassin> _assassinsRepository;

        public AssassinsEncounter(ConsoleColor color, string startLine, string endLine, IRepository<Assassin> assassinsRepository) : base(color, startLine, endLine, assassinsRepository)
        {
            _assassinsRepository = assassinsRepository;
        }

        protected override void Accept(Player player, Assassin npc)
        {
            Console.WriteLine(" How much are you willing to spend on a contract?");
            var rewardString = Console.ReadLine();
            if (decimal.TryParse(rewardString, out var reward))
            {
                var assassin = _assassinsRepository.Get().FirstOrDefault(a => a.MinReward <= reward && a.MaxReward >= reward && !a.IsOccupied);
                if (assassin == null)
                {
                    Console.WriteLine(" There was no assassin for such price. You got killed.");
                    Decline(player);
                }
                else
                {
                    assassin.IsOccupied = true;
                    AssasinRelease(assassin);
                    player.DecreaseMoneyAmount(reward);
                }
            }
            else
            {
                Console.WriteLine(" There was no point to joke with us.");
                Decline(player);
            }
        }

        protected void AssasinRelease(Assassin assassin)
        {
            var task = Task.Run(delegate ()
            {
                Thread.Sleep(15000);
                assassin.IsOccupied = false;
            });
        }
    }
}
