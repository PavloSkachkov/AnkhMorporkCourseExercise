using System.Collections.Generic;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Repositories
{
    class ThievesRepository : IRepository<Thief>
    {
        private readonly List<Thief> _thieves = new()
        {
            new Thief("thief")
        };

        public List<Thief> Get() => _thieves;
    }
}
