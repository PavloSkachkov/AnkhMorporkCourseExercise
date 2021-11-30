namespace AnkhMorporkCourseExercise.Models
{
    public class Thiev
    {
        public int AcceptableNumberOfThefts { get; private set; }
        public decimal Fee { get; private set; }
        public int CurrentThefts { get; set; }

        public Thiev()
        {
            AcceptableNumberOfThefts = 6;
            Fee = 10m;
        }
    }
}
