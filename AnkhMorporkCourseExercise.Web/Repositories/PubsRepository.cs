using System;
using System.Collections.Generic;
using System.Linq;
using AnkhMorporkCourseExercise.Web.DAL;
using AnkhMorporkCourseExercise.Web.Models;

namespace AnkhMorporkCourseExercise.Web.Repositories
{
    public class PubsRepository : IRepository<Pub>
    {
        private readonly ApplicationDbContext _dbContext;
        public PubsRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public List<Pub> Get() => _dbContext.Pubs.ToList();

        public void Update(Pub entity)
        {
            throw new NotImplementedException();
        }
    }
}