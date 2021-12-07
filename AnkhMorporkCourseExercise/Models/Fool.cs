namespace AnkhMorporkCourseExercise.Models
{
    public class Fool
    {
        public string Name { get; }
        public decimal Earnings { get; }

        public Fool(string name, decimal earnings)
        {
            Name = name;
            Earnings = earnings;
        }
    }
}
