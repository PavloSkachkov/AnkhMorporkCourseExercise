using System.Collections.Generic;
using System.Linq;
using AnkhMorporkCourseExercise.Web.DAL;
using AnkhMorporkCourseExercise.Web.Models;

namespace AnkhMorporkCourseExercise.Web.Repositories
{
    public class FoolsRepository : IRepository<Fool>
    {
        private readonly ApplicationDbContext _dbContext;
        public FoolsRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public List<Fool> Get() => _dbContext.Fools.ToList();
        public void Update(Fool entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
