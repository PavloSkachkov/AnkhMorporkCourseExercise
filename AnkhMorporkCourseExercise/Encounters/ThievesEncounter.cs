using System;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Encounters
{
    class ThievesEncounter : BaseEncounter<Thiev>
    {
        private Thiev thiev;
        public ThievesEncounter(ConsoleColor color, string startLine, string endLine, Thiev thiev) : base(color, startLine, endLine)
        {
            this.thiev = thiev;
        }

        protected override void Accept(Player player)
        {
            if (thiev.CurrentThefts < thiev.AcceptableNumberOfThefts)
            {
                player.DecreaseMoneyAmount(thiev.Fee);
                thiev.CurrentThefts++;
            }
            else
                Console.WriteLine(" You're lucky. We did everything we wanted for today.");
        }
    }
}
