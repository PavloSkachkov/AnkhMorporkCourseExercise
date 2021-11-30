using System.Collections.Generic;

namespace AnkhMorporkCourseExercise.Repositories
{
    interface IRepository<T>
    {
        List<T> Get();
    }
}