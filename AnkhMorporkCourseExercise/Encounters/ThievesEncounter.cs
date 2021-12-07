using System;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Encounters
{
    class ThievesEncounter : BaseEncounter<Thief>
    {
        private Thief thief;
        public ThievesEncounter(ConsoleColor color, string startLine, string endLine, Thief thief) : base(color, startLine, endLine)
        {
            this.thief = thief;
        }

        protected override void Accept(Player player)
        {
            if (thief.CurrentThefts < thief.AcceptableNumberOfThefts)
            {
                player.DecreaseMoneyAmount(thief.Fee);
                thief.CurrentThefts++;
            }
            else
                Console.WriteLine(" You're lucky. We did everything we wanted for today.");
        }
    }
}
