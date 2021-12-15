using System.Collections.Generic;
using System.Linq;
using AnkhMorporkCourseExercise.Web.DAL;
using AnkhMorporkCourseExercise.Web.Models;

namespace AnkhMorporkCourseExercise.Web.Repositories
{
    public class AssassinsRepository : IRepository<Assassin>
    {
        private readonly ApplicationDbContext _dbContext;
        public AssassinsRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public List<Assassin> Get() => _dbContext.Assassins.ToList();

        public void Update(Assassin currentAssassin)
        {
            var assassinInDb = _dbContext.Assassins.SingleOrDefault(a => a.Id == currentAssassin.Id);
            if (assassinInDb != null)
            {
                assassinInDb.IsOccupied = currentAssassin.IsOccupied;
                _dbContext.SaveChanges();
            }
        }
    }
}
