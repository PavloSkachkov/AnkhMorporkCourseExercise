using System.Collections.Generic;
using System.Linq;
using AnkhMorporkCourseExercise.Web.DAL;
using AnkhMorporkCourseExercise.Web.Models;

namespace AnkhMorporkCourseExercise.Web.Repositories
{
    public class BeggarsRepository : IRepository<Beggar>
    {
        private readonly ApplicationDbContext _dbContext;
        public BeggarsRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public List<Beggar> Get() => _dbContext.Beggars.ToList();
        public void Update(Beggar entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
