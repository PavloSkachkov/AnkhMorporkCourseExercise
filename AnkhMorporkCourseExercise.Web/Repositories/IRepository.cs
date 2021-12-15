using System.Collections.Generic;

namespace AnkhMorporkCourseExercise.Web.Repositories
{
    public interface IRepository<T> 
    {
        List<T> Get();
        void Update(T entity);
    }
}