using System;
using AnkhMorporkCourseExercise.Models;
using AnkhMorporkCourseExercise.Repositories;

namespace AnkhMorporkCourseExercise.Encounters
{
    class FoolsEncounter : BaseEncounter<Fool>
    {
        private readonly IRepository<Fool> _foolsRepository;

        public FoolsEncounter(ConsoleColor color, string startLine, string endLine, IRepository<Fool> beggarsRepository) : base(color, startLine, endLine)
        {
            _foolsRepository = beggarsRepository;
        }
        protected override void Accept(Player player)
        {
            var fool = GetRandomEntity(_foolsRepository.Get());
            player.IncreaseMoneyAmount(fool.Earnings);
        }

        protected override void Decline(Player player)
        {
            Console.WriteLine(endLine);
        }
    }
}
