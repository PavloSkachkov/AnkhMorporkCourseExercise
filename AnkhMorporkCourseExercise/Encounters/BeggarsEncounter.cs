using System;
using AnkhMorporkCourseExercise.Models;
using AnkhMorporkCourseExercise.Repositories;

namespace AnkhMorporkCourseExercise.Encounters
{
    class BeggarsEncounter : BaseEncounter<Beggar>
    {
        private readonly IRepository<Beggar> _beggarsRepository;
        public BeggarsEncounter(ConsoleColor color, string startLine, string endLine, IRepository<Beggar> beggarsRepository) : base(color, startLine, endLine)
        {
            _beggarsRepository = beggarsRepository;
        }

        protected override void Accept(Player player)
        {
            var beggar = GetRandomEntity(_beggarsRepository.Get());
            player.DecreaseMoneyAmount(beggar.Alm);
        }
    }
}
