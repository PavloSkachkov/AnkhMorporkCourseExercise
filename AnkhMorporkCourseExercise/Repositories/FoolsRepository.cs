using System.Collections.Generic;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Repositories
{
    class FoolsRepository : IRepository<Fool>
    {
        private readonly List<Fool> _fools = new()
        {
            new Fool("Muggin", 0.5m),
            new Fool("Gull", 1),
            new Fool("Dupe", 2),
            new Fool("Butt", 3),
            new Fool("Fool", 5),
            new Fool("Tomfool", 6),
            new Fool("Stupid Fool", 7),
            new Fool("Arch Fool", 8),
            new Fool("Complete Fool", 10)
        };

        public List<Fool> Get() => _fools;
    }
}
