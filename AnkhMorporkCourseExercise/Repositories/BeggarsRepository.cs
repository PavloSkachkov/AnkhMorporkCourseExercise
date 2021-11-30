using System.Collections.Generic;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Repositories
{
    class BeggarsRepository : IRepository<Beggar>
    {
        private readonly List<Beggar> _beggars = new()
        {
            new Beggar("Twitcher", 3),
            new Beggar("Drooler", 2),
            new Beggar("Dribbler", 1),
            new Beggar("Mumbler", 1),
            new Beggar("Mutterers", 0.9m),
            new Beggar("Walking-Along-Shouter", 0.8m),
            new Beggar("Demander of a Chip", 0.6m),
            new Beggar("The one, who Call Other People Jimmy", 0.5m),
            new Beggar("The one, who Need Eightpence For A Meal", 0.08m),
            new Beggar("The one, who Need Tuppence For A Cup Of Tea", 0.02m),
            new Beggar("People With Placards Saying 'Why lie? I need a beer.'", 0)
        };

        public List<Beggar> Get() => _beggars;
    }
}
