namespace AnkhMorporkCourseExercise.Models
{
    public class Thiev
    {
        public int AcceptableNumberOfThefts { get; }
        public decimal Fee { get; }
        public int CurrentThefts { get; set; }

        public Thiev()
        {
            AcceptableNumberOfThefts = 6;
            Fee = 10m;
        }
    }
}
