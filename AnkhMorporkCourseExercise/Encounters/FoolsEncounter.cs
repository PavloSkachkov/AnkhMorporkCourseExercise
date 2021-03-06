using System;
using AnkhMorporkCourseExercise.Models;
using AnkhMorporkCourseExercise.Repositories;

namespace AnkhMorporkCourseExercise.Encounters
{
    class FoolsEncounter : BaseEncounter<Fool>
    {
        public FoolsEncounter(ConsoleColor color, string startLine, string endLine, IRepository<Fool> foolsRepository) : base(color, startLine, endLine, foolsRepository)
        {
        }

        protected override void Accept(Player player, Fool npc)
        {
            player.IncreaseMoneyAmount(npc.DealMoneyAmount);
        }

        protected override void Decline(Player player)
        {
            Console.WriteLine(endLine);
        }
    }
}
