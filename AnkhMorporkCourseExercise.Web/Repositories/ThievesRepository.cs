using System.Collections.Generic;
using System.Linq;
using AnkhMorporkCourseExercise.Web.DAL;
using AnkhMorporkCourseExercise.Web.Models;

namespace AnkhMorporkCourseExercise.Web.Repositories
{
    public class ThievesRepository : IRepository<Thief>
    {
        private readonly ApplicationDbContext _dbContext;
        public ThievesRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public List<Thief> Get() => _dbContext.Thieves.ToList();
        public void Update(Thief entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
