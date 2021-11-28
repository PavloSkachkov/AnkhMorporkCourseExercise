namespace AnkhMorporkCourseExercise
{
    public class Thiev
    {
        public int AcceptableNumberOfThefts { get; private set; }
        public double Fee { get; private set; }
        public int CurrentThefts { get; set; }

        public Thiev()
        {
            AcceptableNumberOfThefts = 6;
            Fee = 10;
        }
    }
}
