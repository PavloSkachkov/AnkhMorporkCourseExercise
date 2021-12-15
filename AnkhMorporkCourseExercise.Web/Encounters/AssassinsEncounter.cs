using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Encounters
{
    public class AssassinsEncounter : BaseEncounter<Assassin>
    {
        private readonly IRepository<Assassin> _assassinsRepository;

        public AssassinsEncounter(IRepository<Assassin> assassinsRepository) : base(assassinsRepository)
        {
            _assassinsRepository = assassinsRepository;
        }

        public override bool Accept(Player player, Assassin npc)
        {
            Accept(player, npc, 0);
            return true;
        }

        public bool Accept(Player player, Assassin npc, decimal moneyAmount)
        {
            var assassin = _assassinsRepository.Get().FirstOrDefault(a => a.MinReward <= moneyAmount && a.MaxReward >= moneyAmount && !a.IsOccupied);
            if (assassin == null || player.CurrentMoneyAmount <= moneyAmount)
            {
                return false;
            }
            else
            {
                assassin.IsOccupied = true;
                _assassinsRepository.Update(assassin);
                AssasinRelease(assassin);
                player.DecreaseMoneyAmount(moneyAmount);
                return true;
            }
        }

        public void AssasinRelease(Assassin assassin)
        {
            var task = Task.Run(delegate ()
            {
                Thread.Sleep(15000);
                assassin.IsOccupied = false;
                _assassinsRepository.Update(assassin);
            });
        }
    }
}
