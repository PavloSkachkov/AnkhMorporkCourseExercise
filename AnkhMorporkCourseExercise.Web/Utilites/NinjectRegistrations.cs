using Ninject.Modules;
using AnkhMorporkCourseExercise.Web.DAL;
using AnkhMorporkCourseExercise.Web.Encounters;
using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;
using Ninject.Web.Common;

namespace AnkhMorporkCourseExercise.Web.Utilites
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<AssassinsEncounter>().ToSelf().InRequestScope();
            Bind<BeggarsEncounter>().ToSelf().InRequestScope();
            Bind<FoolsEncounter>().ToSelf().InRequestScope();
            Bind<ThievesEncounter>().ToSelf().InSingletonScope();
            Bind<PubsEncounter>().ToSelf().InRequestScope();

            Bind<ApplicationDbContext>().ToSelf().InRequestScope();

            Bind<IRepository<Assassin>>().To<AssassinsRepository>().InRequestScope();
            Bind<IRepository<Beggar>>().To<BeggarsRepository>().InRequestScope();
            Bind<IRepository<Fool>>().To<FoolsRepository>().InRequestScope();
            Bind<IRepository<Thief>>().To<ThievesRepository>().InRequestScope();
            Bind<IRepository<Pub>>().To<PubsRepository>().InRequestScope();
            Bind<Player>().ToSelf().InSingletonScope();
        }
    }
}