namespace AnkhMorporkCourseExercise
{
    public class Fool
    {
        public string Name { get; private set; }
        public double Earnings { get; private set; }

        public Fool(string name, double earnings)
        {
            this.Name = name;
            this.Earnings = earnings;
        }
    }
}
