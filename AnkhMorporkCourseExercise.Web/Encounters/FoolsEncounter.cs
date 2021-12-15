using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Encounters
{
    public class FoolsEncounter : BaseEncounter<Fool>
    {
        public FoolsEncounter(IRepository<Fool> foolsRepository) : base(foolsRepository)
        {
        }

        public override bool Accept(Player player, Fool npc)
        {
            player.IncreaseMoneyAmount(npc.DealMoneyAmount);
            return true;
        }

        public override void Decline(Player player)
        {
        }
    }
}
