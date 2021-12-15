using System.Collections.Generic;
using AnkhMorporkCourseExercise.Web.Models;

namespace AnkhMorporkCourseExercise.Web.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AnkhMorporkCourseExercise.Web.DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AnkhMorporkCourseExercise.Web.DAL.ApplicationDbContext context)
        {
            context.Fools.RemoveRange(context.Fools);
            context.Thieves.RemoveRange(context.Thieves);
            context.Assassins.RemoveRange(context.Assassins);
            context.Beggars.RemoveRange(context.Beggars);
            context.Pubs.RemoveRange(context.Pubs);

            var assassins = new List<Assassin>()
            {
                new Assassin("assassin1", 1, 3),
                new Assassin("assassin2",3, 5),
                new Assassin("assassin3",5, 8),
                new Assassin("assassin4",7, 12),
                new Assassin("assassin5",10, 20),
                new Assassin("assassin6",12, 20),
                new Assassin("assassin7",15, 19),
                new Assassin("assassin8",15, 30),
                new Assassin("assassin9",16, 25),
                new Assassin("assassin10", 20, 30)
            };
            context.Assassins.AddRange(assassins);

            var beggars = new List<Beggar>()
            {
                new Beggar("Twitcher", 3),
                new Beggar("Drooler", 2),
                new Beggar("Dribbler", 1),
                new Beggar("Mumbler", 1),
                new Beggar("Mutterers", 0.9m),
                new Beggar("Walking-Along-Shouter", 0.8m),
                new Beggar("Demander of a Chip", 0.6m),
                new Beggar("The one, who Call Other People Jimmy", 0.5m),
                new Beggar("The one, who Need Eightpence For A Meal", 0.08m),
                new Beggar("The one, who Need Tuppence For A Cup Of Tea", 0.02m),
                new Beggar("People With Placards Saying 'Why lie? I need a beer.'", 0)
            };
            context.Beggars.AddRange(beggars);

            var fools = new List<Fool>()
            {
                new Fool("Muggin", 0.5m),
                new Fool("Gull", 1),
                new Fool("Dupe", 2),
                new Fool("Butt", 3),
                new Fool("Fool", 5),
                new Fool("Tomfool", 6),
                new Fool("Stupid Fool", 7),
                new Fool("Arch Fool", 8),
                new Fool("Complete Fool", 10)
            };
            context.Fools.AddRange(fools);

            var thieves = new List<Thief>()
            {
                new Thief("thief")
            };
            context.Thieves.AddRange(thieves);

            var pubs = new List<Pub>()
            {
                new Pub("The Mended Drum")
            };
            context.Pubs.AddRange(pubs);

            base.Seed(context);
        }
    }
}
