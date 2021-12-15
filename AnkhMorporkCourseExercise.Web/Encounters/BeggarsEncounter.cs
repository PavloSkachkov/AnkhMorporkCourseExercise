using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Encounters
{
    public class BeggarsEncounter : BaseEncounter<Beggar>
    {
        public BeggarsEncounter(IRepository<Beggar> beggarsRepository) : base(beggarsRepository)
        {
        }

        public override bool Accept(Player player, Beggar npc)
        {
            if (npc.DealMoneyAmount == 0)
            {
                if (player.BeerAmount > 0)
                {
                    player.BeerAmount -= 1;
                    return true;
                }

                return false;
            }

            player.DecreaseMoneyAmount(npc.DealMoneyAmount);

            return true;
        }
    }
}
