using System;
using AnkhMorporkCourseExercise.Models;
using AnkhMorporkCourseExercise.Repositories;

namespace AnkhMorporkCourseExercise.Encounters
{
    class ThievesEncounter : BaseEncounter<Thief>
    {
        public ThievesEncounter(ConsoleColor color, string startLine, string endLine, IRepository<Thief> thievesRepository) : base(color, startLine, endLine, thievesRepository)
        {
        }

        protected override void Accept(Player player, Thief npc)
        {
            if (npc.CurrentThefts < npc.AcceptableNumberOfThefts)
            {
                player.DecreaseMoneyAmount(npc.DealMoneyAmount);
                npc.CurrentThefts++;
            }
            else
                Console.WriteLine(" You're lucky. We did everything we wanted for today.");
        }
    }
}
