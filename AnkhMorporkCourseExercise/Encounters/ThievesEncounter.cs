using System;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Encounters
{
    class ThievesEncounter : BaseEncounter<Thief>
    {
        private readonly Thief _thief;
        public ThievesEncounter(ConsoleColor color, string startLine, string endLine, Thief thief) : base(color, startLine, endLine)
        {
            _thief = thief;
        }

        protected override void Accept(Player player)
        {
            if (_thief.CurrentThefts < _thief.AcceptableNumberOfThefts)
            {
                player.DecreaseMoneyAmount(_thief.Fee);
                _thief.CurrentThefts++;
            }
            else
                Console.WriteLine(" You're lucky. We did everything we wanted for today.");
        }
    }
}
