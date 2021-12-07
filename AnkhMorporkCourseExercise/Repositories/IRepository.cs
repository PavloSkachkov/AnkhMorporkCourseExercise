using System.Collections.Generic;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Repositories
{
    public interface IRepository<T> where T : NPC
    {
        List<T> Get();
    }
}