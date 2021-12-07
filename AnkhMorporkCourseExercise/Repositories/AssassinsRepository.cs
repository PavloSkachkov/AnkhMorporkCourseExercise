using System.Collections.Generic;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Repositories
{
    class AssassinsRepository : IRepository<Assassin>
    {
        private readonly List<Assassin> _assassins = new()
        {
            new Assassin("assassin1", 1, 3),
            new Assassin("assassin2",3, 5),
            new Assassin("assassin3",5, 8),
            new Assassin("assassin4",7, 12),
            new Assassin("assassin5",10, 20),
            new Assassin("assassin6",12, 20),
            new Assassin("assassin7",15, 19),
            new Assassin("assassin8",15, 30),
            new Assassin("assassin9",16, 25),
            new Assassin("assassin10", 20, 30)
        };

        public List<Assassin> Get() => _assassins;
    }
}
