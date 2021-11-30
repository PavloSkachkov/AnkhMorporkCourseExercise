using System.Collections.Generic;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Repositories
{
    class AssassinsRepository : IRepository<Assassin>
    {
        private readonly List<Assassin> _assassins = new()
        {
            new Assassin(1, 3),
            new Assassin(7, 12),
            new Assassin(10, 20),
            new Assassin(15, 19),
            new Assassin(15, 30)
        };

        public List<Assassin> Get() => _assassins;
    }
}
