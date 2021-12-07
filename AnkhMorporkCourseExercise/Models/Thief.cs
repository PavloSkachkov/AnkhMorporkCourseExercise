namespace AnkhMorporkCourseExercise.Models
{
    public class Thief
    {
        public int AcceptableNumberOfThefts { get; }
        public decimal Fee { get; }
        public int CurrentThefts { get; set; }

        public Thief()
        {
            AcceptableNumberOfThefts = 6;
            Fee = 10m;
        }
    }
}
