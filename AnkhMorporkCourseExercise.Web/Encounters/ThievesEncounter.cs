using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Encounters
{
    public class ThievesEncounter : BaseEncounter<Thief>
    {
        public static int CurrentThefts = 0;
        public static int AcceptableNumberOfThefts = 6;
        public ThievesEncounter(IRepository<Thief> thievesRepository) : base(thievesRepository)
        {
        }

        public override bool Accept(Player player, Thief npc)
        {
            if (!player.IsAlive)
            {
                return false;
            }
            if (ThievesEncounter.CurrentThefts < ThievesEncounter.AcceptableNumberOfThefts)
            {
                player.DecreaseMoneyAmount(npc.DealMoneyAmount);
                ThievesEncounter.CurrentThefts++;
                return true;
            }
            return false;
        }
    }
}
