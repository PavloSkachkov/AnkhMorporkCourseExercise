namespace AnkhMorporkCourseExercise.Models
{
    public class Fool
    {
        public string Name { get; private set; }
        public decimal Earnings { get; private set; }

        public Fool(string name, decimal earnings)
        {
            this.Name = name;
            this.Earnings = earnings;
        }
    }
}
