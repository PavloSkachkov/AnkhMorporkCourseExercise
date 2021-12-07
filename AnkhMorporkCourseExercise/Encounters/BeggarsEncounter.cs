using System;
using AnkhMorporkCourseExercise.Models;
using AnkhMorporkCourseExercise.Repositories;

namespace AnkhMorporkCourseExercise.Encounters
{
    class BeggarsEncounter : BaseEncounter<Beggar>
    {
        public BeggarsEncounter(ConsoleColor color, string startLine, string endLine, IRepository<Beggar> beggarsRepository) : base(color, startLine, endLine, beggarsRepository)
        {
        }

        protected override void Accept(Player player, Beggar npc)
        {
            player.DecreaseMoneyAmount(npc.DealMoneyAmount);
        }
    }
}
