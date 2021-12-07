namespace AnkhMorporkCourseExercise.Models
{
    public class Thief : NPC
    {
        public int AcceptableNumberOfThefts { get; }
        public int CurrentThefts { get; set; }

        public Thief(string name) : base(name, 10m)
        {
            AcceptableNumberOfThefts = 6;
        }
    }
}
