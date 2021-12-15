using System.Data.Entity;
using AnkhMorporkCourseExercise.Web.Models;

namespace AnkhMorporkCourseExercise.Web.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Assassin> Assassins { get; set; }
        public DbSet<Beggar> Beggars { get; set; }
        public DbSet<Fool> Fools { get; set; }
        public DbSet<Thief> Thieves { get; set; }
        public DbSet<Pub> Pubs { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}